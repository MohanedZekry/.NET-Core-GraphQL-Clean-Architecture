using AnimeGraphQL.Domain.Common;

namespace AnimeGraphQL.Domain.Entities
{
    public class Anime : BaseEntity
    {
        public string Name { get; set; }
        public double Rate { get; set; }
        public string Story { get; set; }

    }
}
