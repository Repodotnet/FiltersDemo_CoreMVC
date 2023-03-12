using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersDemo_CoreMVC.Filters
{
    public class SampleActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Sample Action executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Sample Action executing");
        }
    }
}
