namespace AnimeGraphQL.Application.Repository
{
    public interface IUnitOfWork
    {
        Task Save(CancellationToken cancellationToken);
    }
}
