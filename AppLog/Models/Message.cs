using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public String Title { get; set; }
        
        public String Text { get; set; }
        
        public String RequestInfo { get; set; }
        
        public String UserInfo { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime? ReadAt { get; set; }

        public int MessageTypeId { get; set; }
        
        public int ProjectId { get; set; }


        [ForeignKey("MessageTypeId")]
        public virtual MessageType MessageType { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}