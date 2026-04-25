using Autofac;

namespace BackEnd.Aritmica.DependencyInjection
{
    public static class DependencyInjectionControl
    {
        internal static IContainer Container { get; private set; }
        internal static int AmountOfTimesConstructed { get; private set; }

        public static void BuildContainerWithDependenciesWithoutLoadingData()
        {
            try
            {
                var containerBuilder = new ContainerBuilder();
                RegistryDependenciesWithoutLoadData(containerBuilder);
                BuildContainer(containerBuilder);
            }
            catch (Exception exception)
            {
                // ignored
            }
        }

        private static void RegistryDependenciesWithoutLoadData(ContainerBuilder containerBuilder) => 
            containerBuilder.RegisterModule<WholeSystemModulesWithoutLoadingDataInjection>();

        private static void BuildContainer(ContainerBuilder containerBuilder)
        {
            Container = containerBuilder.Build();
            AmountOfTimesConstructed++;
        }
    }
}
