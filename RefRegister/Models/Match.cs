using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefRegister.Models
{
    public class Match
    {
        
        public int Id { get; set; }
        [Display(Name = "Match Nummer")]
        public int MatchNumber { get; set; }
        [Display(Name ="Datum & Tid")]
        public DateTime GameDate { get; set; }
        [Display(Name = "Arena")]
        public ICollection<Arena> Arena { get; set; }
        [Display(Name = "Hemma Lag")]
        public ICollection<Team> Team1 { get; set; }
        [Display(Name = "Borta Lag")]
        public ICollection<Team> Team2 { get; set; }
        [Display(Name = "Mål")]
        public int Score1 { get; set; }
        [Display(Name = "Mål")]
        public int Score2 { get; set; }
        [Display(Name = "HD")]
        public ICollection<Referee> Ref1 { get; set; }
        [Display(Name = "HD")]
        public ICollection<Referee> Ref2 { get; set; }
        [Display(Name = "LD")]
        public ICollection<Referee> Ref3 { get; set; }
        [Display(Name = "LD")]
        public ICollection<Referee> Ref4 { get; set; }
        [Display(Name = "HD Arvode")]
        public ICollection<Fee> Fee1 { get; set; }
        [Display(Name = "HD Arvode")]
        public ICollection<Fee> Fee2 { get; set; }
        [Display(Name = "LD Arvode")]
        public ICollection<Fee> Fee3 { get; set; }
        [Display(Name = "LD Arvode")]
        public ICollection<Fee> Fee4 { get; set; }       

    }
}
