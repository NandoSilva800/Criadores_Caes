using System;
using Microsoft.EntityFrameworkCore;
using CriadorCaes.Models;

namespace CriadorCaes.Data
{
    /// <summary>
	/// representa a DB dos criadores de caes
	/// </summary>
    public class CriadorCaesBD : DbContext
    {
        //******************************************************
        //especificar as tabelas na BD
        //****************************************************

        public DbSet<Criadores> Criadores{ get; set;}

        public DbSet<Caes> Caes { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<CriadoresCaes> CriadoresCaes{ get; set; }
        //*******************************************************
    }
}
