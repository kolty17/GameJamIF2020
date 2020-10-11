using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrGameController : MonoBehaviour
{

    public GameObject character;
    public Slider maxVel;
    public Slider minVel;
    public Slider realVel;
    public Slider vel;
    public float delta = 0.4f;
    float time;
    [System.NonSerialized]
    public float diff;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (vel.value == 0) vel.value = 0.05f;
        time = character.GetComponentInChildren<ScrNubeProbabilistica>().time;
        maxVel.value = vel.value + (delta / time);
        minVel.value = vel.value - (delta / time);
        realVel.value = Random.Range(minVel.value, maxVel.value);
        character.GetComponent<ScrMomentum>().speed = realVel.value * 1;
        diff = maxVel.value - minVel.value;
    }
}
