using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefRegister.Models
{
    public class Referee
    {
        public int Id { get; set; }
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }
        [Display(Name = "Gatuadress")]
        public string StreetAddress { get; set; }
        [Display(Name = "Post.NR")]
        public string ZipCode { get; set; }
        [Display(Name = "Post.ORT")]
        public string City { get; set; }
        [Display(Name = "Mobilnummer")]
        public string PhoneNumber { get; set; }
        [Display(Name = "E-Post")]
        public string Email { get; set; }
        [Display(Name = "Domar.NR")]
        public string RefNumber { get; set; }
    }
}
