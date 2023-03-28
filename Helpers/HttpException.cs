namespace WebApi.Helpers;

using System.Globalization;
using System.Net;

/// <summary>Special Exception for setting Http Status and Message</summary>
/// <remarks>
///   custom exception class for throwing application specific exceptions (e.g. for validation) 
///   that can be caught and handled within the application
/// </remarks>
/// <seealso cref="System.Exception" />
public class HttpException : Exception {

    /// <summary>Gets the Http Status code.</summary>
    /// <value>The Http Status Code.</value>
    public HttpStatusCode Code { get; }

    /// <summary>Initializes a new instance of the <see cref="HttpException"/> class.</summary>
    /// <param name="code">The code.</param>
    public HttpException(HttpStatusCode code)
      : base() {
        Code = code;
    }

    /// <summary>Initializes a new instance of the <see cref="HttpException"/> class.</summary>
    /// <param name="code">The code.</param>
    /// <param name="message">The message.</param>
    public HttpException(HttpStatusCode code, string message)
      : base(message) {
        Code = code;
    }

    /// <summary>Initializes a new instance of the <see cref="HttpException"/> class.</summary>
    /// <param name="code">The code.</param>
    /// <param name="message">The message.</param>
    /// <param name="args">The arguments.</param>
    public HttpException(HttpStatusCode code, string message, params object[] args)
      : base(String.Format(CultureInfo.CurrentCulture, message, args)) {
        Code = code;
    }
}