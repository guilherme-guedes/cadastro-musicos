namespace Data.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        public AbstractContext Context { get;}

        public UnitOfWork(AbstractContext context)
        {
            this.Context = context;
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }
        
        public void Dispose()
        {
           this.Context.Dispose();            
        }
    }
}