using System;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; private set; }
        public DateTimeOffset CreatedAt { get; private set; }
        public DateTimeOffset LastUpdateAt { get; private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }
        
        public void ModifiedEntity()
        {
            LastUpdateAt = DateTime.Now;
        }
    }
}
