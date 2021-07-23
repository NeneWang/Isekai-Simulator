using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnumRaces
{
    Human, Elf, Orc, Dwarf
}



// TODO: Work on the class types later
public enum classType
{
    Fighter, Swordman, Ranger, Archer, Assasin, Mechanic
}


public class Person
{

    string name, gender;
    EnumRaces race = EnumRaces.Human;

    int age = 18, level = 1;
    public Person(string nameIn)
    {
        name = nameIn;

    }

    public string getRace()
    {

        string[] races = { "Human", "Elf", "Orc", "Dwarf" };
        return races[((int)race)];
    }

    public void levelUp()
    {

    }

    public void oneYearOlder()
    {
        age++;
    }

}
