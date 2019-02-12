using System.Data;
using System.Data.SqlClient;
using Ninject;
using SolidWorkshop.Entities;
using SolidWorkshop.Repositories;
using SolidWorkshop.Services;

namespace DependencyResolver
{
    public static class ResolverModule
    {
        private const string DefaultConnection = "[connectionString]";

        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IService>().To<Service>();
            kernel.Bind<IRepository<Entity>>().To<Repository>();
            kernel.Bind<IDbConnection>().To<SqlConnection>()
                .WithConstructorArgument("connectionString", DefaultConnection);
        }
    }
}