using System;

namespace SolidWorkshop.Entities
{
    /// <summary>
    /// Represents an entity.
    /// </summary>
    public class Entity : IEntity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a timestamp when the entity was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
