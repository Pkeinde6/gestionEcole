namespace AppGestionCahierTexte.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;
    using AppGestionCahierTexte.Model;
    using AppGestionCahierTexte.Utils;

    public sealed class Configuration : DbMigrationsConfiguration<AppGestionCahierTexte.Model.BDCahierDeTexteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AppGestionCahierTexte.Model.BDCahierDeTexteContext context)
        {
            // Créer l'admin par défaut
            if (!context.administrateurs.Any(a => a.CodeU == "ADM001"))
            {
                using (MD5 md5 = MD5.Create())
                {
                    context.administrateurs.Add(new Administrateur
                    {
                        NomU = "Admin",
                        PrenomU = "ClassLog",
                        CodeU = "ADM001",
                        EmailU = "admin@classlog.com",
                        PhoneU = "0000000000",
                        AdresseU = "ClassLog HQ",
                        MotDePasse = Crypto.GetMd5Hash(md5, "admin123"),
                        Fonction = "Administrateur Général"
                    });
                }
                context.SaveChanges();
            }

            // Mettre à jour les emails existants en @classlog.com
            var utilisateurs = context.utilisateurs.ToList();
            foreach (var u in utilisateurs)
            {
                // Ne pas toucher à l'email de l'admin
                if (u.CodeU == "ADM001") continue;

                if (!string.IsNullOrEmpty(u.EmailU) && !u.EmailU.EndsWith("@classlog.com"))
                {
                    string emailBase = (u.NomU.Trim().ToLower() + "." + u.PrenomU.Trim().ToLower()).Replace(" ", "");
                    u.EmailU = emailBase + "@classlog.com";
                }
                else if (string.IsNullOrEmpty(u.EmailU))
                {
                    string emailBase = (u.NomU.Trim().ToLower() + "." + u.PrenomU.Trim().ToLower()).Replace(" ", "");
                    u.EmailU = emailBase + "@classlog.com";
                }
            }
            context.SaveChanges();
        }
    }
}
