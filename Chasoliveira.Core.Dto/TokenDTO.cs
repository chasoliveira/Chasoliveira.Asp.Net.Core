using System;

namespace Chasoliveira.Core.Dto
{
    public class TokenDTO
    {
        public string AuthToken { get; set; }
        public DateTime ExpiresOn { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime LastSync { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public virtual bool IsValid
        {
            get { return ExpiresOn > DateTime.Now; }
        }
    }
}
