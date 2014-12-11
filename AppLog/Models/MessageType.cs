using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class MessageType
    {
        [Key]
        public int Id { get; set; }


        public String Name { get; set; }
        
        public String Tag { get; set; }
        
        public String Icon { get; set; }
        
        public String CssClass { get; set; }
    }
}