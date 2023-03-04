using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ardalis.Specification
{
  /// <summary>
  /// <para>
  /// A <see cref="IRepositoryBase{T}" /> can be used to query and save instances of <typeparamref name="T" />.
  /// An <see cref="ISpecification{T}"/> (or derived) is used to encapsulate the LINQ queries against the database.
  /// </para>
  /// </summary>
  /// <typeparam name="T">The type of entity being operated on by this repository.</typeparam>
  public interface IRepositoryBase<T> : IReadRepositoryBase<T> where T : class
  {
    /// <summary>
    /// Adds an entity in the database.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// </returns>
    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds the given entities in the database
    /// </summary>
    /// <param name="entities"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// </returns>
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an entity in the database
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    void Update(T entity);

    /// <summary>
    /// Updates the given entities in the database
    /// </summary>
    /// <param name="entities">The entities to update.</param>
    void UpdateRange(IEnumerable<T> entities);

    /// <summary>
    /// Removes an entity in the database
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    void Delete(T entity);

    /// <summary>
    /// Removes the given entities in the database
    /// </summary>
    /// <param name="entities">The entities to remove.</param>
    void DeleteRange(IEnumerable<T> entities);
  }
}
