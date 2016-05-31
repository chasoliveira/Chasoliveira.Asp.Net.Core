using System.Collections.Generic;

namespace Chasoliveira.Core.Dto
{
    public class UserDTO
    {
        public UserDTO()
        {
            Tokens = new List<TokenDTO>();
        }
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int PersonId { get; set; }
        public virtual PersonDTO Person { get; set; }
        public virtual ICollection<TokenDTO> Tokens { get; set; }
    }
}
