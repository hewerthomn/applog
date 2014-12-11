using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppLog
{
    public class NotificationLink
    {
        public string linkText = "";
        public string action = "";
        public string controller = "";
        public RouteValueDictionary routeValues = null;
        public RouteValueDictionary htmlAttributes = null;

        public NotificationLink(String linkText, String action, String controller, Object routeValues, Object htmlAttributes)
        {
            this.action = action;
            this.linkText = linkText;
            this.controller = controller;
            this.routeValues = new RouteValueDictionary(routeValues);
            this.htmlAttributes = new RouteValueDictionary(htmlAttributes);
        }
    }

    public static class Notification
    {
        public static void alert(this Controller instance, String Text, String Class, List<NotificationLink> links = null, String Icon = "check")
        {
            if (links == null)
            {
                links = new List<NotificationLink>();
            }

            foreach (NotificationLink link in links)
            {
                Text += " " + HtmlHelper.GenerateLink(instance.Request.RequestContext, System.Web.Routing.RouteTable.Routes, link.linkText, "", link.action, link.controller, link.routeValues, link.htmlAttributes);
            }

            instance.TempData["AlertMessage"] = Text;
            instance.TempData["AlertClass"] = Class;
            instance.TempData["AlertIcon"] = "<i class=\"fa fa-" + Icon + " fa-lg\"></i>";
        }

        public static void alert(this Controller instance, String Text, String Class, NotificationLink link, String Icon = "check")
        {
            Text += " " + HtmlHelper.GenerateLink(instance.Request.RequestContext, System.Web.Routing.RouteTable.Routes, link.linkText, "", link.action, link.controller, link.routeValues, link.htmlAttributes);

            instance.TempData["AlertMessage"] = Text;
            instance.TempData["AlertClass"] = Class;
            instance.TempData["AlertIcon"] = "<i class=\"fa fa-" + Icon + " fa-lg\"></i>";
        }

        public static void success(this Controller instance, String Text, List<NotificationLink> links = null, String Icon = "check")
        {
            instance.alert(Text, "success", links, Icon);
        }

        public static void success(this Controller instance, String Text, NotificationLink link, String Icon = "check")
        {
            instance.alert(Text, "success", link, Icon);
        }

        public static void error(this Controller instance, String Text, List<NotificationLink> links = null, String Icon = "times")
        {
            instance.alert(Text, "danger", links, Icon);
        }

        public static void error(this Controller instance, String Text, NotificationLink link, String Icon = "times")
        {
            instance.alert(Text, "danger", link, Icon);
        }

        public static void info(this Controller instance, String Text, List<NotificationLink> links = null, String Icon = "info-circle")
        {
            instance.alert(Text, "info", links, Icon);
        }

        public static void info(this Controller instance, String Text, NotificationLink link, String Icon = "info-circle")
        {
            instance.alert(Text, "info", link, Icon);
        }

        public static void warning(this Controller instance, String Text, List<NotificationLink> links = null, String Icon = "warning")
        {
            instance.alert(Text, "warning", links, Icon);
        }

        public static void warning(this Controller instance, String Text, NotificationLink link, String Icon = "warning")
        {
            instance.alert(Text, "warning", link, Icon);
        }

        public static void exception(this Controller instance, String Text, Exception ex, List<NotificationLink> links = null, String Icon = "bug")
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }

            Text += String.Format(" <span class=\"label label-danger\" title=\"{0}\"><i class=\"fa fa-exclamation-sign\"></i> Exception</span>", ex.Message);
            instance.error(Text, links, Icon);
        }

        public static void exception(this Controller instance, String Text, Exception ex, NotificationLink link, String Icon = "bug")
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }

            Text += String.Format(" <span class=\"label label-danger\" title=\"{0}\"><i class=\"fa fa-exclamation-sign\"></i> Exception</span>", ex.Message + ex.StackTrace);
            instance.error(Text, link, Icon);
        }
    }
}