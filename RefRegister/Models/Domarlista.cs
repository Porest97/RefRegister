using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefRegister.Models
{
    public class Domarlista
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefNumber { get; set; }
        public string BirthDate { get; set; }
        public string RefType { get; set; }
        public string Category { get; set; }
        public string CategoryType { get; set; }
        public string Distrikt { get; set; }
        public string Club { get; set; }
        public string StreetAddress { get; set; }
        public string Zipcode { get; set; }
        public string County { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Registred { get; set; }
        public string Created { get; set; }
        public string Payed { get; set; }
    }
}
