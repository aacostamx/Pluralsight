namespace POS.DataLayer.Migrations
{
    using POS.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<POS.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(POS.DataLayer.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder { CustomerName="Antonio Acosta", PONumber="6671318545" },
                new SalesOrder { CustomerName = "Grisell Lopez", PONumber = "5539556441" },
                new SalesOrder { CustomerName = "Delfina Murillo"},
                new SalesOrder { CustomerName = "Jose Manuel" },
                new SalesOrder { CustomerName = "Rafaela Navarro", PONumber = "6677144574" }

                );
        }
    }
}
