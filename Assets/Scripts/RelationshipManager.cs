using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationshipManager
{
    // MAX 2 friends
    public static int maxFriends = 6;
    public int currentAmountFriends = 0;
    public Person[] friends = new Person[maxFriends];
    // Friends 
    public Person lover, player;

    public void initializeFriendsWithString(string[] friendsData)
    {
        for (int i = 0; i < friendsData.Length; i++)
        {
            // Debug.Log("Initializing: " + friendsData[i]);
            friends[i] = dataToPerson(friendsData[i]);
            currentAmountFriends++;
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

    public Person getFriendN(int friendNumber)
    {
        if (friendNumber > currentAmountFriends)
        {
            return friends[0];
        }

        // Debug.Log("Attempted to get friend" + "using " + friendNumber.ToString());

        return friends[friendNumber];

    }


    // public void addFriend(Person friendToAdd)
    // {

    //     currentAmountFriends++;
    //     if (friends.Length >= maxFriends)
    //     {
    //         return;
    //     }

    //     friends.Add(friendToAdd);
    // }

    public Person[] getFriends()
    {
        return friends;
    }

}
