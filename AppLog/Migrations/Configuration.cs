namespace AppLog.Migrations
{
    using AppLog.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<AppLog.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AppLog.Models.DatabaseContext";
        }

        protected override void Seed(AppLog.Models.DatabaseContext context)
        {
            context.MessageType.AddRange(new List<MessageType>()
            {
                new MessageType()
                {
                    Name = "Success",
                    Tag = "success",
                    CssClass = "success",
                    Icon= "check"
                },

                new MessageType()
                {
                    Name = "Information",
                    Tag = "info",
                    CssClass = "info",
                    Icon= "info-cicle"
                },

                new MessageType()
                {
                    Name = "Warning",
                    Tag = "warning",
                    CssClass = "warning",
                    Icon= "warning"
                },

                new MessageType()
                {
                    Name = "Exception",
                    Tag = "exception",
                    CssClass = "danger",
                    Icon= "bug"
                },


            });
            
            context.SaveChanges();
        }
    }
}