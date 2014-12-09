using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public String About { get; set; }
        
        public String URL { get; set; }
        
        public String ApiKey { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
    }
}