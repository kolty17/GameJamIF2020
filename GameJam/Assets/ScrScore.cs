using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrScore : MonoBehaviour
{
    public GameObject obj;
    Text score;
    static public float scoreReached;
    // Start is called before the first frame update
    void Start()
    {
        scoreReached = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreReached = (obj.transform.position.z / 10);
        score.text = scoreReached.ToString("N0");
    }
}
