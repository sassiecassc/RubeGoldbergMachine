﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacebar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            Destroy(gameObject);
        }
    }
}
