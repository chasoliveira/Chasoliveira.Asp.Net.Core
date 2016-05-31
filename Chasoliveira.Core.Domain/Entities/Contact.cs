namespace Chasoliveira.Core.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Ord { get; set; }
        public virtual Person Person { get; set; }
    }
}
