using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Helpers
{
    public static class ActiveNavLinkBootstrapHelper
    {
        public static string IsActive(this IHtmlHelper htmlHelper, string controllers, string actions, string cssClass = "nav-link active")
        {
            var currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            var currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;

            if (string.IsNullOrEmpty(currentAction) || string.IsNullOrEmpty(currentController))
                return string.Empty;

            IEnumerable<string> acceptedActions = (actions ?? currentAction).Split(',');
            IEnumerable<string> acceptedControllers = (controllers ?? currentController).Split(',');

            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ? cssClass : "nav-link";
        }
    }
}
