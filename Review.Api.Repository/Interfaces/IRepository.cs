using Review.Api.Repository.Entities;

namespace Review.Api.Repository.Interfaces
{
    public interface IRepository<TEntity, VId>
        where TEntity : BaseEntity<VId>, new()
    {
        /// <summary>
        /// Get all Entities
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="OperationCanceledException">Operation canceled exception</exception>
        /// <exception cref="ArgumentNullException">Argument null exception</exception>
        /// <exception cref="ArgumentException">Argument exception</exception>
        /// <exception cref="Exceptions.RepositoryException">Repository exception</exception>
        /// <returns>Entities</returns>
        Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Entity by Id
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="OperationCanceledException">Operation canceled exception</exception>
        /// <exception cref="ArgumentNullException">Argument null exception</exception>
        /// <exception cref="ArgumentException">Argument exception</exception>
        /// <exception cref="Exceptions.RepositoryException">Repository exception</exception>
        /// <returns>Entity</returns>
        Task<TEntity> GetById(VId id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Entity
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="OperationCanceledException">Operation canceled exception</exception>
        /// <exception cref="ArgumentNullException">Argument null exception</exception>
        /// <exception cref="ArgumentException">Argument exception</exception>
        /// <exception cref="Exceptions.RepositoryException">Repository exception</exception>
        /// <returns>Entity</returns>
        Task<VId> Create(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="OperationCanceledException">Operation canceled exception</exception>
        /// <exception cref="ArgumentNullException">Argument null exception</exception>
        /// <exception cref="ArgumentException">Argument exception</exception>
        /// <exception cref="Exceptions.RepositoryException">Repository exception</exception>
        /// <returns>Entity</returns>
        Task Update(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Entity by Id
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="OperationCanceledException">Operation canceled exception</exception>
        /// <exception cref="ArgumentNullException">Argument null exception</exception>
        /// <exception cref="ArgumentException">Argument exception</exception>
        /// <exception cref="Exceptions.RepositoryException">Repository exception</exception>
        /// <returns>Entity</returns>
        Task Delete(VId id, CancellationToken cancellationToken = default);
    }
}
