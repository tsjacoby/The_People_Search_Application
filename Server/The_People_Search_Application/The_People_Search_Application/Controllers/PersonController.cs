using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using The_People_Search_Application.Contexts;

namespace The_People_Search_Application.Controllers
{
    /// <summary>
    /// The person controller. The class for handling person related network requests.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PeopleContext _context;

        /// <summary>
        /// Creates the person controller class based on the given people context.
        /// </summary>
        /// <param name="context"></param>
        public PersonController(PeopleContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// The method for handling requests of the form:
        ///     Get api/people/searchByName(Bill)
        /// This method searches for people by name with the given search text.
        /// </summary>
        /// <param name="searchText">The search text to use.</param>
        /// <returns>The search results.</returns>
        [HttpGet("searchByName({searchText})")]
        public ActionResult<Models.Person[]> SearchByName(string searchText)
        {
            Models.Person[] searchResults = this._context.SearchByName(searchText);
            return searchResults;
        }
    }
}
