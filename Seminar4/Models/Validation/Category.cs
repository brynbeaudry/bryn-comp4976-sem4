using System;
using System.ComponentModel.DataAnnotations;
using Seminar4.Models.NorthWind;

namespace Seminar4.Models
{

    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
        public static implicit operator Category(Seminar4.Models.NorthWind.Category v)
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryMetaData
    {
        [Required]
        [Display(Name = "Category Name")]
        public object CategoryName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public object Description { get; set; }
    }
}