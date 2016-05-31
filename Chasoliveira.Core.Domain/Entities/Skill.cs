namespace Chasoliveira.Core.Domain.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Icon { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public decimal Progress { get; set; }
        public int Ord { get; set; }
        public virtual Person Person { get; set; }
    }
}
