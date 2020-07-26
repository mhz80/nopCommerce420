using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widget.HelloWorld.Components
{
    [ViewComponent(Name = "HelloWorldWidget")]
    public class HelloWorldWidgetViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke(string widgetZone)
        {
            return Content("Hello World");
        }

    }
}
