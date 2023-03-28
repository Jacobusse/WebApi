namespace WebApi.Helpers;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

/// <summary>Handles Errors by use of Exceptions</summary>
public class ErrorHandlerMiddleware {

    /// <summary>Error Message Class</summary>
    public class ErrorMessage {
        /// <summary>Gets or sets the message.</summary>
        /// <value>The message.</value>
        [JsonPropertyName("errorMessage")]
        public string? Message { get; set; }

        /// <summary>Initializes a new instance of the <see cref="ErrorMessage"/> class.</summary>
        /// <param name="message">The message.</param>
        public ErrorMessage(string? message) {
            Message = message;
        }
    }
    
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    /// <summary>Initializes a new instance of the <see cref="ErrorHandlerMiddleware"/> class.</summary>
    /// <param name="next">The next.</param>
    /// <param name="logger">The logger.</param>
    public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger) {
        _next = next;
        _logger = logger;
    }

    /// <summary>Invokes the specified context.</summary>
    /// <param name="context">The context.</param>
    public async Task Invoke(HttpContext context) {
        try {
            await _next(context);
        } catch (Exception error) {
            var response = context.Response;
            response.ContentType = "application/json";

            switch (error) {
                case HttpException e: // Custom Error
                    response.StatusCode = (int)e.Code;
                    break;
                case KeyNotFoundException: // Not Found Error
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                case FormatException: // Wrong Format
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                default: // Unhandled Error
                    _logger.LogError(error, error.Message);
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonSerializer.Serialize(new ErrorMessage(error?.Message));
            await response.WriteAsync(result);
        }
    }
}