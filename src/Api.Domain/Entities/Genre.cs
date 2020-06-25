namespace Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; private set;}

        public Genre()
        {
        }

        public Genre(string name)
        {
            this.Name = name;
        }
    }
}