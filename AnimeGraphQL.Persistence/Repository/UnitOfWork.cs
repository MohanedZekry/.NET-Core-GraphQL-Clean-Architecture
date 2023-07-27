
using AnimeGraphQL.Application.Repository;
using AnimeGraphQL.Persistence.Context;

namespace AnimeGraphQL.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AnimeContext _context;

        public UnitOfWork(AnimeContext context)
        {
            _context = context;
        }
        public Task Save(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
