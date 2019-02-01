using System;
using System.Collections.Generic;
using SolidWorkshop.Entities;
using SolidWorkshop.Repositories;

namespace SolidWorkshop.Services
{
    /// <summary>
    /// Represents service.
    /// </summary>
    public class Service : IService
    {
        #region Fields

        /// <summary>
        /// Repository field.
        /// </summary>
        private readonly IRepository<Entity> repository;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Service"/> class.
        /// </summary>
        /// <param name="repository">Specific repository.</param>
        /// <exception cref="ArgumentNullException">Thrown when repository value is null.</exception>
        public Service(IRepository<Entity> repository)
        {
            this.repository = repository ?? throw new ArgumentNullException($"{nameof(repository)} cannot be null.");
        }

        #endregion

        #region IService implementation

        /// <inheritdoc/>
        public List<Entity> ReadAll()
        {
            return new List<Entity>(this.repository.GetAll());
        }

        /// <inheritdoc/>
        public Entity Save(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} cannot be null.");
            }

            var result = this.repository.Save(entity);

            return result;
        }

        #endregion
    }
}
