using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScrNubeProbabilistica : MonoBehaviour
{
    float time;
    public float maxDimension = 7f;
    public float expansion = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            time = time + expansion;
        }
        else
        {
            time = time - expansion;
        }
        if (time >= maxDimension) time = maxDimension;
        if (time <= 1) time = 1;

        transform.localScale = new Vector3(150 * time, 150 * time, 150 / time);

    }
}
