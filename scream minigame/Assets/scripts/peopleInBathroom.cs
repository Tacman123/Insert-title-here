using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peopleInBathroom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("numPeople", Random.Range(2, 9));
    }
}
