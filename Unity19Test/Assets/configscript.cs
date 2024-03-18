using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configscript : MonoBehaviour
{
    // Start is called before the first frame updat

    void OnCollisionEnter(UnityEngine.Collision other)
    {
        Debug.Log("working");
        if (other.gameObject.tag == "Object")
        {
            //Output the message
            Debug.Log("working");
        }
    }

    void OnCollisionStay(UnityEngine.Collision other)
    {
        Debug.Log("contact");
        if (other.gameObject.tag == "Object")
        {
            //Output the message
            Debug.Log("contact");
        }
    }
}
