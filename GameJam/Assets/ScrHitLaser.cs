using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScrHitLaser : MonoBehaviour
{
    public float minVelocita;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent<ScrGameController>().diff < minVelocita)
            {
                SceneManager.LoadScene("LvGameOver", LoadSceneMode.Single);
            }
        }
    }

}
