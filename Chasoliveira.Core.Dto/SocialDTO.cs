namespace Chasoliveira.Core.Dto
{
    public class SocialDTO
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Ord { get; set; }
        public virtual PersonDTO Person { get; set; }
    }
}
