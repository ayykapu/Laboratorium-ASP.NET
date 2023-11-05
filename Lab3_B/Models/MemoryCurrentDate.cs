namespace Lab3_B.Models
{
    public class MemoryCurrentDate : ICurrentDate
    {
        public DateTime CurrentTime 
        {
            get => DateTime.Now;
        }
    }
}
