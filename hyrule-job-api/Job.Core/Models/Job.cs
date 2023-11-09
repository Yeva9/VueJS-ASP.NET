namespace Job.Core.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Loaction { get; set; } = string.Empty;
        public int Salary { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsFav { get; set; }
    }
}
