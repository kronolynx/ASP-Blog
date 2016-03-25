using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KronoBlog.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class SelectedTabAttribute : ActionFilterAttribute
    {
        private readonly string selectedTab;
        public SelectedTabAttribute(string selectedTab)
        {
            this.selectedTab = selectedTab;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // set selected tab to the current tab in the viewdata
            filterContext.Controller.ViewBag.SelectedTab = selectedTab;
        }
    }
}