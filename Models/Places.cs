using System.Collections.Generic;
using System;


namespace PlacesIveBeen.Models
{
  public class Places
  {

    public string Description {get; set;}
    public int Id { get; }
    private static List<Places> _instances = new List<Places>{};
   
    public Places(string description)
    {
        Description = description;
        _instances.Add(this);
        Id = _instances.Count;
    }

    public static List<Places> GetAll()
    {
        return _instances;
    }
    
    public static void ClearAll()
    {
        _instances.Clear();
    }
    public static Places Find(int searchId)
    {
      return _instances[searchId - 1 ];
    }
  }
}