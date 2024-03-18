using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactScript : MonoBehaviour
{
    bool isInContact = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Object")
        { // Replace "YourTag" with the tag of the objects you want to detect collision with
            isInContact = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Object")
        { // Replace "YourTag" with the tag of the objects you want to detect collision with
            isInContact = false;
        }
    }

    public bool IsInContact()
    {
        return isInContact;
    }
}