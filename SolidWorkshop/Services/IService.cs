using System;
using System.Collections.Generic;
using SolidWorkshop.Entities;

namespace SolidWorkshop.Services
{
    /// <summary>
    /// Service interface.
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Reads all entities.
        /// </summary>
        /// <returns>A <see cref="List{Entity}"/>.</returns>
        List<Entity> ReadAll();

        /// <summary>
        /// Saves the entity.
        /// </summary>
        /// <param name="entity">Specific entity.</param>
        /// <returns>An <see cref="Entity"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when entity value is null.</exception>
        Entity Save(Entity entity);
    }
}