using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLog.Models.Repository
{
    public class AppSettingsRepository : Repository
    {

        private static object GetKey(string key, object defaultValue)
        {
            AppSettings appSettings = db.AppSettings.FirstOrDefault(x => x.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase));
            if (appSettings != null)
            {
                return appSettings.Value;
            }

            return defaultValue;
        }

        public static object Get(string key, object defaultValue)
        {
            return GetKey(key, defaultValue);
        }

        public static bool GetBoolean(string key, bool defaultValue)
        {
            object value = GetKey(key, defaultValue);
            
            return Convert.ToBoolean(value);
        }

        public static string GetString(string key, string defaultValue)
        {
            object value = GetKey(key, defaultValue);

            return value.ToString();
        }

        public static int GetInt(string key, int defaultValue)
        {
            object value = GetKey(key, defaultValue);

            return Convert.ToInt32(value);
        }

        public static decimal GetDecimal(string key, decimal defaultValue)
        {
            object value = GetKey(key, defaultValue);

            return Convert.ToDecimal(value);
        }

    }
}