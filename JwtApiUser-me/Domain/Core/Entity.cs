using JwtApiUser_me.Domain.Contract;

namespace JwtApiUser_me.Domain.Core
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
