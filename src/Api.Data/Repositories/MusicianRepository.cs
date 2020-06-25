using Data.Transaction;
using Domain.Entities;
using Domain.IRepositories;

namespace Data.Repositories
{
    public class MusicianRepository : BaseRepository<Musician>, IMusicianRepository
    {
        public MusicianRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}