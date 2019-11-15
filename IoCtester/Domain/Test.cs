using IoCtester.DomainService;

namespace IoCtester.Domain
{
    public class Test
    {
        private readonly IDataService _svc;

        public Test(IDataService svc)
        {
            _svc = svc;
        }

        public void Do(string message)
        {
            _svc.Test(message);
        }
    }
}
