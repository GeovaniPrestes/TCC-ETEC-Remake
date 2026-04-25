using Autofac;
using BackEnd.Aritmica.Features.Person.Repositories;
using BackEnd.Aritmica.Features.Person.Repositories.Interfaces;
using BackEnd.Aritmica.Features.Person.Services;
using BackEnd.Aritmica.Features.Person.Services.Interfaces;

namespace BackEnd.Aritmica.Features.Person.Injection
{
    public class PersonInjection : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            try
            {
                containerBuilder.RegisterType<StudentService>().As<IStudentService>();
                containerBuilder.RegisterType<StudentRepository>().As<IStudentRepository>();
            }
            catch (Exception exception)
            {
                // ignored
            }
        }
    }
}
