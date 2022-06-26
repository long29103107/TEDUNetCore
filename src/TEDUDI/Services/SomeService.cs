namespace TEDUDI.Services
{
    public class SomeService : IScopedService, ISingletonService, ITransientService
    {
        Guid _id;
        public SomeService()
        {
            _id = Guid.NewGuid(); 
        }
        public Guid GetById()
        {
            return _id;
        }
    }
}
