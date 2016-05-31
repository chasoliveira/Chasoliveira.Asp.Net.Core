using System;

namespace Chasoliveira.Core.Domain.Entities
{
    public class Token
    {
        public int Id { get; set; }
        public string AuthToken { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime ExpiresOn { get; set; }
        public DateTime LastSync { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual bool IsValid
        {
            get { return ExpiresOn > DateTime.Now; }
        }
    }
}