using System;

namespace Chasoliveira.Core.Dto
{
    public class HistoryDTO
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public HistoryType HistoryType { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Finished { get; set; }
        public string FinishedString
        {
            get
            {
                return Finished?.ToString("yyyy") ?? "present";
            }
        }
        public string Description { get; set; }
        public virtual bool IsCurrently { get { return !Finished.HasValue; } }
        public int Ord { get; set; }
        public virtual PersonDTO Person { get; set; }
    }

    public enum HistoryType
    {
        Education,
        Position,
        Courses,
    }
}
