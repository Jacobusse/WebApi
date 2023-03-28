using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApi.Entities;

/// <summary>Contact Class</summary>
public class Contact {

    /// <summary>Gets or sets the identifier.</summary>
    /// <value>The identifier.</value>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = String.Empty;

    /// <summary>Gets or sets the first name.</summary>
    /// <value>The first name.</value>
    public string? FirstName { get; set; }

    /// <summary>Gets or sets the last name.</summary>
    /// <value>The last name.</value>
    public string? LastName { get; set; }

    /// <summary>Gets or sets the email.</summary>
    /// <value>The email.</value>
    public string Email { get; set; } = String.Empty;

    /// <summary>Gets or sets the phone.</summary>
    /// <value>The phone.</value>
    public string? Phone { get; set; }

    /// <summary>Gets or sets the address.</summary>
    /// <value>The address.</value>
    public Address Address { get; set; } = new Address();
}