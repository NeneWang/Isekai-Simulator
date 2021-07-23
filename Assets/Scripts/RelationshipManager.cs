using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationshipManager
{
    // MAX 2 friends
    public List<Person> friends = new List<Person>();
    public int maxFriends = 2;
    // Friends 
    Person marriagePartner;

    public void initializeFriendsWithString(){
        
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
