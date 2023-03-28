using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services;

public interface IBillOfLadingService : IService<BillOfLading, StandardIdentity> {
    Task<List<BillOfLading>> Search();
}

public class BillOfLadingService : IBillOfLadingService {

    private readonly IMongoCollection<BillOfLading> _tableBol;

    public BillOfLadingService(IOptions<WebApiDbSettings> options)  {
        var mongoClient = new MongoClient(options.Value.ConnectionString);
        var mongoDb = mongoClient.GetDatabase(options.Value.DatabaseName);

        _tableBol = mongoDb.GetCollection<BillOfLading>(options.Value.BillOfLadingCollectionName);
    }

    public async Task Delete(StandardIdentity id) {
        await _tableBol.DeleteOneAsync(x => x.Id == id.Id);
    }

    public async Task<List<BillOfLading>> GetAll() {
        return await _tableBol.Find(_ => true).ToListAsync();
    }

    public async Task<StandardIdentity> Insert(BillOfLading bol) {
        await _tableBol.InsertOneAsync(bol);
        if (bol?.Id == null)
            throw new KeyNotFoundException("User not added");

        return new StandardIdentity(bol.Id);
    }

    public async Task<BillOfLading> Locate(StandardIdentity id) {
        BillOfLading bol= await _tableBol.Find(x => x.Id == id.Id).FirstOrDefaultAsync();
        if (bol == null)
            throw new KeyNotFoundException("Bill of Lading not found");

        return bol;
    }

    public async Task<StandardIdentity> Modify(BillOfLading bol) {
        if (String.IsNullOrEmpty(bol.Id)) {
            return await Insert(bol);
        } else {
            return await Update(new StandardIdentity(bol.Id), bol);
        }
    }

    public async Task<List<BillOfLading>> Search() {
        throw new NotImplementedException();
    }

    public async Task<StandardIdentity> Update(StandardIdentity id, BillOfLading bol) {
        await _tableBol.ReplaceOneAsync(x => x.Id == id.Id, bol);
        if (bol?.Id == null)
            throw new KeyNotFoundException("Bill of Lading not updated");

        return new StandardIdentity(bol.Id);
    }
}
