using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "LowerBorder")
        {
            Debug.Log("You lost! Explosion happens.");
        }
    }
}
