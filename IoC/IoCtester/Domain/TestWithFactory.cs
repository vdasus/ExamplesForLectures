using IoCtester.DomainService;

namespace IoCtester.Domain
{
    public class TestWithFactory
    {
        private readonly IDataService _svc;

        public TestWithFactory(string prefix, string postfix)
        {
            _svc = DataServiceFactory.CreateDataSource(prefix, postfix);
        }

        public void Do(string message)
        {
            _svc.Test(message);
        }
    }
}