﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Ball!")
        {
            

        }





    }
}
