using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrWall : MonoBehaviour
{
    public float minDimension;
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
            if (other.gameObject.GetComponent<ScrNubeProbabilistica>().time < minDimension)
            {
                SceneManager.LoadScene("LvGameOver", LoadSceneMode.Single);
            }          
        }
    }
}
