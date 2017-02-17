using Nancy;
using RepeatCounterFunction.Objects;
using System.Collections.Generic;

namespace RepeatCounterFunction
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/results"] = _ => {
                RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["phrase"]);
                return View["results.cshtml", newRepeatCounter];
            };
        }
    }
}
