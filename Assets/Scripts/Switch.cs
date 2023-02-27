using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerStay(Collider other)
    {

        if(other.gameObject.tag == "Player")
        {

           Debug.Log("Switch Activated");
        }

    }
}
