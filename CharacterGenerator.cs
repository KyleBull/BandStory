using UnityEngine;
using System.Collections;

/// <summary>
///  This is my attempt at making a character.
/// </summary>

public class CharacterGenerator
{
    public enum Stats
    {
        Rhythm,
        Vocals, 
        Instrument,
        LevelBonus
    }

    public enum Modifier
    {
        Added,
        Percent,
    }

    public Stats id;
    public Modifier modifier;
    public int amount;
    static public string GetName(Stats i)
    {
        return i.ToString();
    }

    static public string GetDescription(Stats i)
    {
        switch (i)
        {
            case Stats.Rhythm:
                return "Put down some fat beats, Yo";
            case Stats.Vocals:
                return "You sing purtay";
            case Stats.Instrument:
                return "You can play well";
        }
        return null;
    }

  

        //switch (rand)
        //{
        //    case 1:
        //        string[] maleNames = new string[] {
        //    "Kurt Lo Mein", "John Lemon", "Beathoven", "Bob Marmalade", "Elvis Parsley",
        //    "Bruce Springrollstein", "Wolfgang Mozzarella", "Mayonaise Kebab", "LL Koolade", "Wu Tang Flan", "Burrito Mars",
        //    "Ice T", "Snoop Hotdog", 
        //};
        //        character.Name = maleNames[Random.Range(0, maleNames.Length)];
        //        break;
        //    case 2:
        //        string[] femaleNames = new string[] {
        //    "Rebecca Blackberry", "Sheryl Cranberry", "Britney Spearmint", "Susan B Artichoke", "Lady GoGurt" , "Joan Beanz", 
        //};
        //        character.Name = femaleNames[Random.Range(0, femaleNames.Length)];
        //        break;
        //}


      

}
