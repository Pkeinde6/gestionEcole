using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BDCahierDeTexteContext : DbContext
    {
        public BDCahierDeTexteContext() : base("ConnCahierDeTexte") {
        
        }
        public DbSet<Classe> classes { get; set; }
        public DbSet<Matiere> matieres { get; set; }

        public DbSet<Utilisateur> utilisateurs { get; set; }

        public DbSet<Professeur>   profsseurs { get;set; }

        public DbSet<ResponsableClasse> responsableClasses { get; set; }

        public DbSet<ChefDepartement> chefDepartements { get; set; }

        public DbSet<ProfesseurMatiere> professeurMatieres { get; set; }

    }
}
