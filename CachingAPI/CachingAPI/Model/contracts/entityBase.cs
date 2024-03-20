namespace CachingAPI.Model.contracts
{
    public abstract class entityBase
    {
        public Guid Id { get; protected set; }

        protected entityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
