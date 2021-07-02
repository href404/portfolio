using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Helpers
{
    public static class ActiveElementBootstrapHelper
    {
        public static string IsElementActive(this IHtmlHelper htmlHelper, string controllers, string actions, string cssClass)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            var currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;

            if (string.IsNullOrEmpty(currentAction) || string.IsNullOrEmpty(currentController))
                return string.Empty;

            IEnumerable<string> acceptedActions = (actions ?? currentAction).Split(',');
            IEnumerable<string> acceptedControllers = (controllers ?? currentController).Split(',');

            var activeCssClass = $"{cssClass} active";
            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ? activeCssClass : cssClass;
        }
    }
}
