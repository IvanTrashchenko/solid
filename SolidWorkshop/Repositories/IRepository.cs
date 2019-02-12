using System.Collections.Generic;

namespace SolidWorkshop.Repositories
{
    /// <summary>
    /// Service repository interface.
    /// </summary>
    /// <typeparam name="TEntity">An entity.</typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Gets all elements of repository.
        /// </summary>
        /// <returns><see cref="IEnumerable{TEntity}"/>.</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Operating for saving the entity.
        /// </summary>
        /// <param name="entity">Specific entity.</param>
        TEntity Save(TEntity entity);
    }
}