using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScrNubeProbabilistica : MonoBehaviour
{
    public float time = 1;
    public float maxDimension = 7f;
    public float expansion = 0.02f;
    public float lateralMove = 10f;
    float position = 0;
    // Start is called before the first frame update
    void Start()
    {
       
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

        if (Input.GetKeyDown("z"))
        {
            if (position == 0)
            {
                transform.position = new Vector3(-7, transform.position.y, transform.position.z);
                position = -1;
            }
            if (position == 1)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                position = 0;
            }
        }
        if (Input.GetKeyDown("c"))
        {
            if (position == 0)
            {
                transform.position = new Vector3(7, transform.position.y, transform.position.z);
                position = 1;
            }
            if (position == -1)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                position = 0;
            }
        }
    }
}
