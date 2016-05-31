using System;

namespace Chasoliveira.Core.Domain.Entities
{
    public class History
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public HistoryType HistoryType { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Finished { get; set; }
        public string Description { get; set; }
        public int Ord { get; set; }
        public virtual Person Person { get; set; }
    }

    public enum HistoryType
    {
        Education,
        Position,
        Courses,
    }
}
