using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScrReplicate : MonoBehaviour
{
    public GameObject piano;
    public GameObject autovelox;
    public GameObject tutor;
    public GameObject muro;
    public GameObject fotocamera;
    bool istanziato;
    float seed;

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
            seed = Random.Range(0, 10);
            if (seed < 4)
            {
                //Instantiate(autovelox, new Vector3(transform.position.x, transform.position.y, transform.position.z + 200), transform.rotation);
                Instantiate(tutor, new Vector3(20, 0, transform.position.z + 250), tutor.transform.rotation);
               
            }
            if (seed < 2)
            {
                Instantiate(muro, new Vector3(0, 10, transform.position.z + 250), muro.transform.rotation);
                Instantiate(muro, new Vector3(8, 10, transform.position.z + 350), muro.transform.rotation);
            }
            if (seed < 5)
            {
                Instantiate(muro, new Vector3(8, 10, transform.position.z + 250), muro.transform.rotation);
                Instantiate(autovelox, new Vector3(-18, 0, transform.position.z + 225), autovelox.transform.rotation);
            }
            if (seed > 5)
            {
                Instantiate(muro, new Vector3(-8, 10, transform.position.z + 250), muro.transform.rotation);
                Instantiate(autovelox, new Vector3(-18, 0, transform.position.z + 275), autovelox.transform.rotation);
            }
            if (seed > 7)
            {
                Instantiate(muro, new Vector3(-8, 10, transform.position.z + 250), muro.transform.rotation);
                Instantiate(muro, new Vector3(0, 10, transform.position.z + 350), muro.transform.rotation);
                Instantiate(fotocamera, new Vector3(-45, 30, transform.position.z + 300), fotocamera.transform.rotation);
            }
            Instantiate(fotocamera, new Vector3(-45, 30, transform.position.z + 350), fotocamera.transform.rotation);
        }



    }
}
