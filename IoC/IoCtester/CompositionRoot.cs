using System;
using DryIoc;
using IoCtester.DomainService;

namespace IoCtester
{
    public static class CompositionRoot
    {
        private static Container Container { get; } = new Container();

        static CompositionRoot()
        {
            InitContainer();
        }

        public static IDataService GetDataService(string prefix, string postfix)
        {
            var getService = Container.Resolve<Func<string, string, IDataService>>();
            return getService(prefix, postfix);
        }

        public static IDataService GetDataServiceWithDefaults()
        {
            return Container.Resolve<IDataService>();
        }

        private static void InitContainer()
        {
            Container.Register<ILoggerService, LoggerService>();
            Container.Register<IDataService, DataService>();
        }
    }
}
