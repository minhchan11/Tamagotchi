using System;
using System.Collections.Generic;

namespace TamagotchiPlay.Objects
{
  public class Tamagotchi
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _sleep;

    private  static List<Tamagotchi> _list = new List<Tamagotchi>{};

    public Tamagotchi(string name, int food, int attention, int sleep)
    {
      _name = name;
      _food = food;
      _attention = attention;
      _sleep = sleep;
    }

    public void SetName(string inputName)
    {
      _name = inputName;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetFood(int inputFood)
    {
      _food = inputFood;
    }

    public int GetFood()
    {
      return _food;
    }

    public void SetAttention(int inputAttention)
    {
      _attention = inputAttention;
    }

    public int GetAttention()
    {
      return _attention;
    }

    public void SetSleep(int inputSleep)
    {
      _sleep = inputSleep;
    }

    public int GetSleep()
    {
      return _sleep;
    }
    public static void Feed(){
      foreach(Tamagotchi tama in _list){
        tama._food = _food + 10;
        tama._attention = _attention -5;
        tama._sleep = _sleep -5;
      }
    }

    public void Play(){
      _food = _food - 20;
      _attention = _attention +10;
      _sleep = _sleep -10;
    }
    public void Bed(){
      _food = _food - 5;
      _attention = _attention - 10;
      _sleep = _sleep +20;
    }
  }
}
