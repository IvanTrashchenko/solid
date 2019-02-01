using System.Collections.Generic;
using SolidWorkshop.Entities;

namespace SolidWorkshop.Repositories
{
    /// <summary>
    /// Service repository interface.
    /// </summary>
    /// <typeparam name="TEntity">An <see cref="IEntity"/>.</typeparam>
    public interface IRepository<TEntity> where TEntity : IEntity
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