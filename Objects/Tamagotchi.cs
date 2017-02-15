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
    private int _id;

    //IMPORTANT TO PUT PUBLIC STATIC HERE SO THAT YOU CAN ACCESS THIS LIST FROM ALL INSTANCES
    public static List<Tamagotchi> _instances = new List<Tamagotchi>{};

    public Tamagotchi(string name, int food, int attention, int sleep)
    {
      _name = name;
      _food = food;
      _attention = attention;
      _sleep = sleep;
      _instances.Add(this);
      _id = _instances.Count;
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

    public int GetId()
    {
      return _id;
    }

    public void SetId(int inputId)
    {
      _id = inputId;
    }

    public static Tamagotchi Find(int id)
    {
      return _instances[id-1];
    }

    public void Feed()
    {
      this._food += 10;
      this._attention += 10;
      this._sleep -= 10;
    }

    public void Play()
    {
      this._food -= 20;
      this._attention += 5;
      this._sleep -= 20;
    }

    public void Bed()
    {
      this._food -= 20;
      this._attention -= 10;
      this._sleep += 20;
    }

    public bool IsDead()
    {
      if((this._food <= 0) || (this._attention <= 0) || (this._sleep <= 0) )
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
