namespace TechReviewMVC.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TechReviewMVC.Models.TechReviewMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TechReviewMVC.Models.TechReviewMVCContext";
        }

        protected override void Seed(TechReviewMVC.Models.TechReviewMVCContext context)
        {

         context.Reviews.AddOrUpdate(x => x.ReviewID,
                new Review ()
                {
                    ReviewID = 1,
                    ReviewTitle = "The Chosen One",
                    ReviewBody = "I will Come back and hunt you",
                    Date = System.DateTime.Now,
                    Author ="Tom Gord",
                    CategoryID = 2

                },
                 new Review()
                 {
                     ReviewID = 2,
                     ReviewTitle = "David Copperfield",
                     ReviewBody = " love you",
                     Date = System.DateTime.Now,
                     Author = "Tom belinger",
                     CategoryID = 1
                 },
                new Review()
                {
                    ReviewID = 3,
                    ReviewTitle = "David Goliath",
                    ReviewBody = "I will Come back and love you",
                    Date = System.DateTime.Now,
                    Author = "Tom Hanks",
                    CategoryID = 3

                },
                  new Review()
                  {
                      ReviewID = 4,
                      ReviewTitle = "What would you do",
                      ReviewBody = "I will Come back and love you and it sucked all at the same time",
                      Date = System.DateTime.Now,
                      Author = "Tom wilcocx",
                      CategoryID = 2
                  },
                   new Review()
                   {
                       ReviewID = 5,
                       ReviewTitle = "marc Ecko pelle pelle",
                       ReviewBody = "I will Come back and love you",
                       Date = System.DateTime.Now,
                       Author = "Tom stone",
                       CategoryID = 1
                   }
                );






            {
                context.Categories.AddOrUpdate(x => x.CategoryID,
                    new Category() { CategoryID = 1, CategoryName = "The Good" },
                    new Category() { CategoryID = 2, CategoryName = "The Bad " },
                    new Category() { CategoryID = 3, CategoryName = "The Ugly" }
                    );

            }







            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
