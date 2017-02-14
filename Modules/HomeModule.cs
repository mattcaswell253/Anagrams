using Nancy;
using System;
using System.Collections.Generic;
using AnagramApp.Objects;

namespace AnagramApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/output"] = _ => {
        Anagram object1 = new Anagram(Request.Form["startingWord"], Request.Form["suggestion1"], Request.Form["suggestion2"], Request.Form["suggestion3"]);
        object1.MatchingWord();
        return View["output.cshtml", object1.outputList];
      };
    }
  }
}
