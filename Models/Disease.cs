namespace Inversity_test.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Severity { get; set; }
        public List<string> Symptoms { get; set; }
        public string Description { get; set; }
    }
}
