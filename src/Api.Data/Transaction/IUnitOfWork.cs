namespace Data.Transaction
{
    public interface IUnitOfWork
    {
        AbstractContext Context {get;}

        void Commit();
    }
}