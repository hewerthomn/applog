using AppLog.Models.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class AppSettings
    {
        [Key]
        public Guid Identity { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }


        public object Get(string key, object defaultValue)
        {
            return AppSettingsRepository.Get(key, defaultValue);
        }

    }
}