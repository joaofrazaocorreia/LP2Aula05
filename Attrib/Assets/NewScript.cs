using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    [SerializeField] private int funnyNumber;

    [SerializeField] [Range(0,500)] private int punnyNumber;

    



    







    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(typeof(NewScript));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
