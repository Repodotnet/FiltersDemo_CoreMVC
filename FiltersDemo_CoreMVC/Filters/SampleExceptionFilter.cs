using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersDemo_CoreMVC.Filters
{
    public class SampleExceptionFilter :Attribute,IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Console.WriteLine("Sample Exception Filter");
            context.Result = new RedirectResult("/Home/errorpage");
        }
    }
}
