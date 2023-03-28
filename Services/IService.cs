using WebApi.Entities;

namespace WebApi.Services;

/// <summary>Service Generic Interface</summary>
/// <typeparam name="T">Serviced Class</typeparam>
/// <typeparam name="I">Identification Class</typeparam>
public interface IService<T, I> 
        where T : class 
        where I : class {

    /// <summary>Deletes the specified identifier.</summary>
    /// <param name="id">The identifier.</param>
    Task Delete(I id); // Remove for Mark for Delete

    /// <summary>Inserts the specified entity.</summary>
    /// <param name="entity">The entity.</param>
    /// <returns>Identity Class</returns>
    Task<I> Insert(T entity); // Create for new min.

    /// <summary>Locates the specified identifier.</summary>
    /// <param name="id">The identifier.</param>
    /// <returns>Identity Class</returns>
    Task<T> Locate(I id); // Single

    /// <summary>Modifies the specified entity. Upsert Action</summary>
    /// <param name="entity">The entity.</param>
    /// <returns>Identity Class</returns>
    Task<I> Modify(T entity); // Upsert, Repair, Adjust

    /// <summary>Updates the specified identifier.</summary>
    /// <param name="id">The identifier.</param>
    /// <param name="entity">The entity.</param>
    /// <returns>Identity Class</returns>
    Task<I> Update(I id, T entity); // Revise for specific value update.


    /// <summary>Gets all. Used for examples.</summary>
    /// <returns>All Entities</returns>
    Task<List<T>> GetAll(); // Entire, Select, Search, Filter
}
