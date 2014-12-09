using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class ProjectUser
    {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public bool Inscribed { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}