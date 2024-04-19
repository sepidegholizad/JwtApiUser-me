namespace JwtApiUser_me.Domain.Contract
{
    public class IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
