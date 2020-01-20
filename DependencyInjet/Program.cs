using Autofac;
using BusinessLib;
using BusinessLib.Utilities;
using System;

namespace DependencyInjet
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using(var scope = container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.Run();
            }
        }
    }
}
