using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services;

public interface IBillOfLadingService : IService<BillOfLading, StandardIdentity> {
    /// <summary>Searches this instance.</summary>
    /// <returns></returns>
    Task<List<BillOfLading>> Search();
}

/// <summary>Service to the Bill of Lading</summary>
/// <seealso cref="WebApi.Services.IBillOfLadingService" />
public class BillOfLadingService : IBillOfLadingService {

    private readonly IMongoCollection<BillOfLading> _tableBol;

    /// <summary>Initializes a new instance of the <see cref="BillOfLadingService"/> class.</summary>
    /// <param name="options">The options.</param>
    public BillOfLadingService(IOptions<WebApiDbSettings> options)  {
        var mongoClient = new MongoClient(options.Value.ConnectionString);
        var mongoDb = mongoClient.GetDatabase(options.Value.DatabaseName);

        _tableBol = mongoDb.GetCollection<BillOfLading>(options.Value.BillOfLadingCollectionName);
    }

    /// <summary>Deletes the specified identifier.</summary>
    /// <param name="id">The identifier.</param>
    public async Task Delete(StandardIdentity id) {
        await _tableBol.DeleteOneAsync(x => x.Id == id.Id);
    }

    /// <summary>Gets all. Used for examples.</summary>
    /// <returns>All Entities</returns>
    public async Task<List<BillOfLading>> GetAll() {
        return await _tableBol.Find(_ => true).ToListAsync();
    }

    /// <summary>Inserts the specified bol.</summary>
    /// <param name="bol">The bol.</param>
    /// <returns></returns>
    /// <exception cref="System.Collections.Generic.KeyNotFoundException">User not added</exception>
    public async Task<StandardIdentity> Insert(BillOfLading bol) {
        await _tableBol.InsertOneAsync(bol);
        if (bol?.Id == null)
            throw new KeyNotFoundException("User not added");

        return new StandardIdentity(bol.Id);
    }

    /// <summary>Locates the specified identifier.</summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Identity Class</returns>
    /// <exception cref="System.Collections.Generic.KeyNotFoundException">Bill of Lading not found</exception>
    public async Task<BillOfLading> Locate(StandardIdentity id) {
        BillOfLading bol= await _tableBol.Find(x => x.Id == id.Id).FirstOrDefaultAsync();
        if (bol == null)
            throw new KeyNotFoundException("Bill of Lading not found");

        return bol;
    }

    /// <summary>Modifies the specified bol.</summary>
    /// <param name="bol">The bol.</param>
    /// <returns></returns>
    public async Task<StandardIdentity> Modify(BillOfLading bol) {
        if (String.IsNullOrEmpty(bol.Id)) {
            return await Insert(bol);
        } else {
            return await Update(new StandardIdentity(bol.Id), bol);
        }
    }

    /// <summary>Searches this instance.</summary>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public async Task<List<BillOfLading>> Search() {
        throw new NotImplementedException();
    }

    /// <summary>Updates the specified identifier.</summary>
    /// <param name="id">The identifier.</param>
    /// <param name="bol">The bol.</param>
    /// <returns></returns>
    /// <exception cref="System.Collections.Generic.KeyNotFoundException">Bill of Lading not updated</exception>
    public async Task<StandardIdentity> Update(StandardIdentity id, BillOfLading bol) {
        await _tableBol.ReplaceOneAsync(x => x.Id == id.Id, bol);
        if (bol?.Id == null)
            throw new KeyNotFoundException("Bill of Lading not updated");

        return new StandardIdentity(bol.Id);
    }
}
