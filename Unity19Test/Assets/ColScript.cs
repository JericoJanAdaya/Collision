using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class ColScript : MonoBehaviour
{
    bool isInContact = false;

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Object")
        {
            isInContact = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Object")
        {
            isInContact = false;
        }
    }

    public bool IsInContact()
    {
        return isInContact;
    }
}