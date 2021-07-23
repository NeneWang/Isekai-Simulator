using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnumRaces
{
    Human, Elf, Orc, Dwarf
}

// TODO: Work on the class types later
public enum EnumFightingClassType
{
    Fighter, Swordman, Ranger, Archer, Assasin, Mechanic
}


// TODO: Change this as Social class type later instead of enums
public enum EnumSocialClassType
{
    FamilyPerson, Friendly, Lovely, Artist, Creative, NaturalFighter, Average
}


public class Person
{
    string[] races = { "Human", "Elf", "Orc", "Dwarf" };


    public string name, gender;
    public EnumRaces race = EnumRaces.Human;
    public EnumSocialClassType socialClassType = EnumSocialClassType.Average;

    public int age = 18, level = 1, relationship;
    public Person(string nameIn)
    {
        name = nameIn;

    }

    public string getRace()
    {

        return races[((int)race)];
    }

    public void levelUp()
    {
        level++;
    }

    public void oneYearOlder()
    {
        age++;
    }

}
