using System;
using System.Collections.Generic;

namespace Chasoliveira.Core.Domain.Entities
{
    public class Person
    {
        public Person()
        {
            Contacts = new List<Contact>();
            Socials = new List<Social>();
            Histories = new List<History>();
            Skills = new List<Skill>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhotoProfile { get; set; }
        public string Occupation { get; set; }
        public string PersonStatment { get; set; }
        public DateTime Birthday { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Social> Socials { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
