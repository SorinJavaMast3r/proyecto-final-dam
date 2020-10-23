using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{

    public float time;

    // Start is called before the first frame update
    void Start()
    {
        this.time = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, time);
    }
}
