using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.RegularExpressions;

namespace Route_Constraints_Custom_Class.CustomConstraints
{
    public class MonthsCustomConstraints : IRouteConstraint
    {
        //check whether the value exists
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(!values.ContainsKey(routeKey)) //month
            {  return false; } //not a match
            Regex regex = new Regex("^(apr|jul|oct|jan)$");
            string? monthValue = Convert.ToString(values[routeKey]);
            if(regex.IsMatch(monthValue)) { return true; } //it's a match
            return false;

        }
    }
}
