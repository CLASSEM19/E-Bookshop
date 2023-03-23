namespace BOOKSHOP.Models.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set;}
    }
}
