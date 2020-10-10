using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScrReplicate : MonoBehaviour
{
    public GameObject piano;
    bool istanziato;

    // Start is called before the first frame update
    void Start()
    {
        istanziato = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (istanziato == false)
        {
            Instantiate(piano, new Vector3(transform.position.x, transform.position.y, transform.position.z + 200), transform.rotation);
            istanziato = true;
        }    
    }
}
