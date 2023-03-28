namespace WebApi.Services;

using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApi.Entities;
using WebApi.Helpers;

/// <summary>Service Interface for Contact</summary>
/// <seealso cref="WebApi.Services.IService&lt;WebApi.Entities.Contact, WebApi.Entities.StandardIdentity&gt;" />
public interface IContactService : IService<Contact, StandardIdentity> {
    /// <summary>Searches the specified cryteria.</summary>
    /// <param name="email">The email.</param>
    /// <param name="phone">The phone.</param>
    /// <returns>Matching Entities</returns>
    Task<List<Contact>> Search(string? email, string? phone);
}

/// <summary>Implements Contact Service</summary>
/// <seealso cref="WebApi.Services.IContactService" />
public class ContactService : IContactService {
    private readonly IMongoCollection<Contact> _tableConatct;

    /// <summary>Initializes a new instance of the <see cref="ContactService"/> class.</summary>
    /// <param name="options">The options.</param>
    public ContactService(IOptions<WebApiDbSettings> options) {
        var mongoClient = new MongoClient(options.Value.ConnectionString);
        var mongoDb = mongoClient.GetDatabase(options.Value.DatabaseName);

        _tableConatct = mongoDb.GetCollection<Contact>(options.Value.ContactCollectionName);
    }

    public async Task<List<Contact>> GetAll() {
        return await _tableConatct.Find(_ => true).ToListAsync();
    }

    public async Task<Contact> Locate(StandardIdentity id) {
        Contact contact = await _tableConatct.Find(c => c.Id == id.Id).FirstOrDefaultAsync();
        if (contact == null)
            throw new KeyNotFoundException("User not found");

        return contact;
    }

    public async Task<StandardIdentity> Insert(Contact contact) {
        await _tableConatct.InsertOneAsync(contact);
        if (contact?.Id == null)
            throw new KeyNotFoundException("User not added");

        return new StandardIdentity(contact.Id);
    }

    public async Task<StandardIdentity> Update(StandardIdentity id, Contact contact) {
        await _tableConatct.ReplaceOneAsync(c => c.Id == id.Id, contact);
        if (contact?.Id == null)
            throw new KeyNotFoundException("User not updated");

        return new StandardIdentity(contact.Id);
    }

    public async Task<StandardIdentity> Modify(Contact entity) {
        if (String.IsNullOrEmpty(entity.Id)) {
            return await Insert(entity);
        } else {
            return await Update(new StandardIdentity(entity.Id), entity);
        }
    }

    public async Task Delete(StandardIdentity id) {
        await _tableConatct.DeleteOneAsync(c => c.Id == id.Id);
    }

    public async Task<List<Contact>> Search(string? email, string? phone) {
        return await _tableConatct
            .Find(c => (c.Email == email && !string.IsNullOrEmpty(email))
                    || (c.Phone == phone && !string.IsNullOrEmpty(phone)))
            .ToListAsync();
    }
}