using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLog.Models.Repository
{
    public class Repository
    {
        protected static DatabaseContext db = new DatabaseContext();
    }
}