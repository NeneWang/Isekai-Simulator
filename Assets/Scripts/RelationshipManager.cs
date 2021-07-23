using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationshipManager 
{
    // MAX 2 friends
    Person[] friends = new Person[2];
    // Friends 
    Person marriage;





    public Person[] getFriends(){
        return friends;
    }

}
