using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Plugin.Tutorial.DistOfCustByCountry.Services;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Infrastructure
{
    class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 1;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<CustomersByCountry>().As<ICustomersByCountry>().InstancePerLifetimeScope();
        }
    }

}
