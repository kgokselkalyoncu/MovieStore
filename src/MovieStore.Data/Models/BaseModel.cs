namespace MovieStore.Data.Models
{
    public class BaseModel
    {
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public Boolean IsDeleted { get; set; } = false;
    }
}