namespace SolidWorkshop.Entities
{
    /// <summary>
    /// An interface for entity with Id. 
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets an entity identifier.
        /// </summary>
        int Id { get; set; }
    }
}
