namespace Inventory.WPF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Inventory.WPF.DbModels;

    internal sealed class Configuration : DbMigrationsConfiguration<Inventory.WPF.Database.WpfInventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Inventory.WPF.Database.WpfInventoryContext context)
        {

            var productUnit1 = new Unit()
            {
                Name = "m2"
            };


            var productUnit2 = new Unit()
            {
                Name = "mb"
            };

            var productUnit3 = new Unit()
            {
                Name = "m3"
            };

            context.Products.Add(new Product()
            {
                Cost = 120,
                Name = new ProductName()
                {
                    Name = "Deska podlogowa warstowa",
                    Description = "Najlepsza deska podłogowa!"
                },
                ProductQuantity = 10,
                ProductTax = new ProductTax()
                {
                    Amout = 23
                },
                ProductUnit = productUnit1
            });

            context.Units.Add(productUnit3);
            context.Units.Add(productUnit2);

            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
