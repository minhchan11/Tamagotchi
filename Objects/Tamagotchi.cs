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
  }
}
