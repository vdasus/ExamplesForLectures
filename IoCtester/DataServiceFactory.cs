using IoCtester.DomainService;

namespace IoCtester
{
    public static class DataServiceFactory
    {
        public static IDataService CreateDataSource(string prefix, string postfix)
        {
            return CompositionRoot.GetDataService(prefix, postfix);
        }
    }
}