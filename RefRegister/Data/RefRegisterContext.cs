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

    }
}
