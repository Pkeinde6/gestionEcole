using AppGestionCahierTexte.Migrations;
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
        static BDCahierDeTexteContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BDCahierDeTexteContext, Configuration>());
        }

        public BDCahierDeTexteContext() : base("ConnCahierDeTexte") {
        
        }
        public DbSet<Classe> classes { get; set; }
        public DbSet<Matiere> matieres { get; set; }

        public DbSet<Utilisateur> utilisateurs { get; set; }

        public DbSet<Professeur>   profsseurs { get;set; }

        public DbSet<ResponsableClasse> responsableClasses { get; set; }

        public DbSet<ChefDepartement> chefDepartements { get; set; }

        public DbSet<Administrateur> administrateurs { get; set; }

        public DbSet<ProfesseurMatiere> professeurMatieres { get; set; }

        public DbSet<Departement> departements { get; set; }

        public DbSet<Syllabus> syllabus { get; set; }

        public DbSet<CahierDeTexte> cahierDeTextes { get; set; }

        public DbSet<Seance> seances { get; set; }

        public DbSet<Devoir> devoirs { get; set; }

        public DbSet<EmploiDuTemps> emploiDuTemps { get; set; }

    }
}
