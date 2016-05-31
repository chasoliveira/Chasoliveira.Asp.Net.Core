using System.Collections.Generic;

namespace Chasoliveira.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
