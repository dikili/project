using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectScreen.Models
{
    public class Project
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Project Name is required !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "PM/AM is required !")]
        public string Pmam { get; set; }
        [Required(ErrorMessage = "Description is required !")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Date is required !")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}