using System;
using System.Collections.Generic;
using System.Data;
using SolidWorkshop.Entities;

namespace SolidWorkshop.Repositories
{
    /// <summary>
    /// Represents service repository.
    /// </summary>
    public class Repository : IRepository<Entity>
    {
        #region Fields

        /// <summary>
        /// Connection field.
        /// </summary>
        private readonly IDbConnection connection;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="connection">Specific connection.</param>
        /// <exception cref="ArgumentNullException">Thrown when connection value is null.</exception>
        public Repository(IDbConnection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException($"{nameof(connection)} cannot be null.");
        }

        #endregion

        #region IRepository implementation

        /// <inheritdoc/>
        public IEnumerable<Entity> GetAll()
        {
            this.connection.Open();

            // perform Save
            this.connection.Close();
            return new List<Entity>();
        }

        /// <inheritdoc/>
        public Entity Save(Entity entity)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        this.connection.Open();

                        // perform Save
                        this.connection.Close();
                        return entity;
                    }
                    catch
                    {
                        if (i == 2)
                            throw;
                    }
                }

                throw new Exception("Ex");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}