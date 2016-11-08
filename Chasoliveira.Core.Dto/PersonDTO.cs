using System;
using System.Collections.Generic;

namespace Chasoliveira.Core.Dto
{
    public partial class PersonDTO
    {
        public PersonDTO()
        {
            Contacts = new List<ContactDTO>();
            Socials = new List<SocialDTO>();
            Histories = new List<HistoryDTO>();
            Skills = new List<SkillDTO>();
            Users = new List<UserDTO>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhotoProfile { get; set; }
        public string Occupation { get; set; }
        public string PersonStatment { get; set; }
        public DateTime Birthday { get; set; }
        public virtual string FullName { get { return $"{FirstName} {MiddleName} {LastName}"; } }
        public virtual string DisplayName { get { return $"{FirstName} {LastName}"; } }
        public virtual int Age
        {
            get
            {
                var now = DateTime.Now;
                var age = now.Year - Birthday.Year;

                if (now.Month < Birthday.Month || (now.Month == Birthday.Month && now.Day < Birthday.Day))
                    age--;

                return age;
            }
        }
        public bool Active { get; set; }
        public virtual ICollection<ContactDTO> Contacts { get; set; }
        public virtual ICollection<SocialDTO> Socials { get; set; }
        public virtual ICollection<HistoryDTO> Histories { get; set; }
        public virtual ICollection<SkillDTO> Skills { get; set; }
        public virtual ICollection<UserDTO> Users { get; set; }
    }
}
