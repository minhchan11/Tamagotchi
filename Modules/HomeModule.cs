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
        string TamaName = Request.Query["new-tamagotchi"];
        Tamagotchi newTamagotchi = new Tamagotchi (TamaName, 100, 100, 100);
        return View["Tama_individual.cshtml",newTamagotchi];
      };
      Post["/feed/{id}"] = parameters => {
        Tamagotchi newTamagotchi = Tamagotchi.Find(parameters.id);
        newTamagotchi.Feed();
        return View["Tama_individual.cshtml",newTamagotchi];
      };
      Post["/play/{id}"] = parameters => {
        Tamagotchi newTamagotchi = Tamagotchi.Find(parameters.id);
        newTamagotchi.Play();
        return View["Tama_individual.cshtml",newTamagotchi];
      };
      Post["/sleep/{id}"] = parameters => {
        Tamagotchi newTamagotchi = Tamagotchi.Find(parameters.id);
        newTamagotchi.Bed();
        return View["Tama_individual.cshtml",newTamagotchi];
      };
    }
  }
}
