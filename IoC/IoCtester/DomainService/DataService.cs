namespace IoCtester.DomainService
{
    public class DataService: IDataService
    {
        private readonly ILoggerService _logger;
        private readonly string _prefix;
        private readonly string _postfix;

        public DataService(ILoggerService logger, string prefix="defaultPrefix", string postfix="defaultPostfix")
        {
            _logger = logger;
            _prefix = prefix;
            _postfix = postfix;
        }

        public string Test(string message)
        {
            _logger.Log($"[{_prefix}][{message}][{_postfix}]");
            return "Test done.";
        }
    }

    public interface IDataService
    {
        string Test(string message);
    }
}
