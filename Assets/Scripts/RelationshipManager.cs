using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationshipManager
{
    // MAX 2 friends
    public List<Person> friends = new List<Person>();
    public int maxFriends = 2;
    // Friends 
    public Person lover, player;

    public void initializeFriendsWithString(string[] friendsData)
    {
        foreach (string friendData in friendsData)
        {


            if (friendData != "EMPTY")
            {



                addFriend(dataToPerson(friendData));
                return;
            }

        }
    }

    public Person dataToPerson(string personString)
    {

        string[] personArray = personString.Split('!');
        


        Person newPerson = new Person(personArray[0]);
        // TODO: Implement race and social classtype later
        newPerson.gender = personArray[0];
        newPerson.age = int.Parse(personArray[4]);
        newPerson.level = int.Parse(personArray[5]);
        newPerson.relationship = int.Parse(personArray[6]);


        return newPerson;

    }


    public void addFriend(Person friendToAdd)
    {

        if (friends.Count >= maxFriends)
        {
            return;
        }

        friends.Add(friendToAdd);
    }

    public List<Person> getFriends()
    {
        return friends;
    }

}
