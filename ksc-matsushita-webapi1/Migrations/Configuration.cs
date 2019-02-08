namespace ksc_matsushita_webapi1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ksc_matsushita_webapi1.Models.NorthWindJDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ksc_matsushita_webapi1.Models.NorthWindJDbContext context)
        {
        }
    }
}
