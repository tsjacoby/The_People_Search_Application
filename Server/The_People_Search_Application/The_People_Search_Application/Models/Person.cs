using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_People_Search_Application.Models
{
    /// <summary>
    /// The class to represent an individual person.
    /// </summary>
    [Serializable()]
    public class Person
    {
        /// <summary>
        /// The key that uniquely identifies a particular person.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// The persons entire name (first + middle + last).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The persons entire address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The persons age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The persons interests.
        /// </summary>
        public string Interests { get; set; }

        /// <summary>
        /// The URL pointing to the persons picture.
        /// </summary>
        public string PictureURL { get; set; }
    }
}
