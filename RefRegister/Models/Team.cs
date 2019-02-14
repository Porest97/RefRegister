using System.Collections.Generic;

namespace RefRegister.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactName { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public ICollection<Person> Staff1 { get; set; }
        public ICollection<Person> Staff2 { get; set; }
        public ICollection<Person> Staff3 { get; set; }
        public ICollection<Person> Staff4 { get; set; }
        public ICollection<Person> Staff5 { get; set; }
    }
}