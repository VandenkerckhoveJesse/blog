using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Web.Models
{
    public class PortfolioInitializer
    {
        public static void Initialize(PortfolioContext context)
        {
            context.Database.EnsureCreated();

            if (context.Articles.Any())
            {
                return;
            }

            var articles = new List<Article>
            {
                new Article{Title = "The hackaton", SubTitle = "1 feb- 3 feb", Date = DateTime.Now, Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Article{Title = "The seminar", SubTitle = "1 feb- 9 feb", Date = DateTime.Now, Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}
            };
            articles.ForEach(article => context.Articles.Add(article));
            context.SaveChanges();
        }
    }
}