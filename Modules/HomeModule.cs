using System;
using System.Collections.Generic;
using Nancy;
using TamagotchiPlay.Objects;

namespace TamagotchiPlay
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["Tama_form.cshtml"];
      Get["/Tama_individual"] = _ => {
        Tamagotchi newTamagotchi = new Tamagotchi(Request.Query["new-tamagotchi"], 100, 100, 100);
        return View["Tama_individual.cshtml",newTamagotchi];
      };
    }
  }
}
