using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrRotateSkybox : MonoBehaviour
{
    float angolo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angolo += 0.1f;
        transform.rotation = Quaternion.Euler(0f, 0f, angolo);
    }
}
