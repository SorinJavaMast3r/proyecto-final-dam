using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorSkills : MonoBehaviour
{

    public Skill energyBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.energyBall.lanzarHabilidad(this.gameObject);
        }
    }
}
