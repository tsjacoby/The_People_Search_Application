using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace The_People_Search_Application.Contexts
{
    /// <summary>
    /// The context for querying the DB for people related data.
    /// </summary>
    public class PeopleContext : DbContext
    {
        /// <summary>
        /// Create the people context based on the given db context options.
        /// </summary>
        /// <param name="options">The db context options.</param>
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }

        /// <summary>
        /// The db set of people.
        /// </summary>
        public DbSet<Models.Person> People { get; set; }

        /// <summary>
        /// Searches for people by name based on the given search text. Any person with a name
        /// that contains the given search text is returned.
        /// </summary>
        /// <param name="SearchText">The search text to search based on.</param>
        /// <returns>The people with names that contain the given search text.</returns>
        public Models.Person[] SearchByName(string SearchText)
        {
            if (SearchText == null || SearchText.Length == 0)
            {
                return new Models.Person[] { };
            }

            var searchResults = (from people in this.People select people).Where(p => p.Name.Contains(SearchText));
            return searchResults.ToArray();
        }
    }
}
