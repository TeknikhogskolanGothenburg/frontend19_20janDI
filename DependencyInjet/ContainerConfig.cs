using Autofac;
using BusinessLib;
using BusinessLib.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DependencyInjet
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<NewLogger>().As<ILogger>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();

            /*builder.RegisterAssemblyTypes(Assembly.Load(nameof(BusinessLib)))
                .Where(t => t.Namespace.Contains(nameof(BusinessLib.Utilities)))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));*/
            return builder.Build();
        }
    }
}
