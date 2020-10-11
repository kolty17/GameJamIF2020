using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrTutor : MonoBehaviour
{
    float timer;
    public float maxTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            timer += Time.deltaTime;            
        }
        if (timer > maxTime)
        {
            SceneManager.LoadScene("LvGameOver", LoadSceneMode.Single);
        }       
    }
}
