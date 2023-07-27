using AnimeGraphQL.Application.Repository;
using AnimeGraphQL.Domain.Common;
using AnimeGraphQL.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AnimeGraphQL.Persistence.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AnimeContext Context;

        public BaseRepository(AnimeContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            Context.Add(entity);
        }

        public void Update(T entity)
        {
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }

        public Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return Context.Set<T>().FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return Context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}
