using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrRotate : MonoBehaviour
{
    public float smooth = 2.0f;
    public float angoloInit = 90f;
    float angolo;
    public float range = 30f;
    bool senso = true;
    // Start is called before the first frame update
    void Start()
    {
        angolo = angoloInit;
    }

    // Update is called once per frame
    void Update()
    {
        if (senso == true) angolo = angolo + smooth;
        if (senso == false) angolo = angolo - smooth;
        if (angolo >= angoloInit + range) senso = false;
        if (angolo <= angoloInit - range) senso = true;
        transform.rotation = Quaternion.Euler(-60f,angolo,-90f);
    }
}
