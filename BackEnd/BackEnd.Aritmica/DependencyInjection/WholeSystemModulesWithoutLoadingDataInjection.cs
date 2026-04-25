using Autofac;
using BackEnd.Aritmica.Connection.Interfaces;
using BackEnd.Aritmica.Data;
using BackEnd.Aritmica.Features.Person.Injection;

namespace BackEnd.Aritmica.DependencyInjection
{
    public class WholeSystemModulesWithoutLoadingDataInjection : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            try
            {
                containerBuilder.RegisterType<ConnectionFactory>().As<IConnectionFactory>();
                containerBuilder.RegisterModule<PersonInjection>();
            }
            catch (Exception exception)
            {
                // ignored
            }
        }
    }
}
