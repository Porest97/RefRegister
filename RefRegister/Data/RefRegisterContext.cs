using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RefRegister.Models;

namespace RefRegister.Models
{
    public class RefRegisterContext : DbContext
    {
        public RefRegisterContext (DbContextOptions<RefRegisterContext> options)
            : base(options)
        {
        }

        public DbSet<RefRegister.Models.Referee> Referee { get; set; }

        public DbSet<RefRegister.Models.Domarlista> Domarlista { get; set; }

        public DbSet<RefRegister.Models.Game> Game { get; set; }

        public DbSet<RefRegister.Models.Arena> Arena { get; set; }

        public DbSet<RefRegister.Models.Person> Person { get; set; }

        public DbSet<RefRegister.Models.Fee> Fee { get; set; }

        public DbSet<RefRegister.Models.Team> Team { get; set; }

        public DbSet<RefRegister.Models.Match> Match { get; set; }

    }
}
