using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppLog.Models
{
    public class Project
    {
        public int Id { get; set; }

        public int OwnerId { get; set; }

        
        public String Name { get; set; }

        public String About { get; set; }
        
        public String URL { get; set; }
        
        public String ApiKey { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }


        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public static string GenerateApiKey()
        {
            String Key = Guid.NewGuid().ToString("N").ToUpper();
            return Key;
        }
    }
}