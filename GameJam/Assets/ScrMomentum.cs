﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMomentum : MonoBehaviour
{
   public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }
}
