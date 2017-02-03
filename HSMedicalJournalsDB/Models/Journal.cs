using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace HSMedicalJournalsDB.Models
{
    public class Journal
    {       
        public Journal()
        {
            PublicationDate = DateTime.Now;
            Publisher = new User();
            Category = new Category();
            Editorial = new Editorial();
        }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        public User Publisher { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Editor")]
        [StringLength(50)]
        public string Editor { get; set; }

        [Required]
        public Editorial Editorial { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Language")]
        [StringLength(20)]
        public string Language { get; set; }

        [Required]
        public string FilePath { get; set; }                
        
        [Required]
        public DateTime PublicationDate { get; set; }
    }
}