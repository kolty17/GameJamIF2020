using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrWriteScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = ScrScore.scoreReached.ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
