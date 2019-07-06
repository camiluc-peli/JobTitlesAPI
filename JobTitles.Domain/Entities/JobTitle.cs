namespace JobTitles.Domain.Entities
{
    public class JobTitle
    {
        public int id { get; set; }
        public int JobTitleId { get; set; }
        public string JobTitleKey { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string Color { get; set; }
    }
}
