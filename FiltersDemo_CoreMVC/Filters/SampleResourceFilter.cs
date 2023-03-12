using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersDemo_CoreMVC.Filters
{
    public class SampleResourceFilter : Attribute,IResourceFilter
    {  
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("Sample Resource Executing Method");
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("Sample Resource Executed Method");
        }

       
    }
}
