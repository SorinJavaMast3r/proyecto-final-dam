using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorSkills : MonoBehaviour
{
    private bool animationExit = false;
    private float animationTime = 0.84f;
    private float animationStartTime;
    private Animator animator;
    private string keyPressed;

    public Skill energyBall;
    public Skill rayo;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            this.animator.Play("First Magic Attack");
            animationStartTime = Time.time + animationTime;
            animationExit = true;
            keyPressed = "q";

        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            this.animator.Play("Second Magic Attack");
            animationStartTime = Time.time + animationTime;
            animationExit = true;
            keyPressed = "e";

        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            this.animator.Play("Third Magic Attack");
            animationStartTime = Time.time + animationTime;
            animationExit = true;
            keyPressed = "r";

        }
    }

    void FixedUpdate()
    {

        if (animationExit && Time.time > animationStartTime)
        {
            switch (keyPressed)
            {
                case "q":
                    this.energyBall.lanzarHabilidad(this.gameObject);
                    animationExit = false;
                    break;
                case "e":
                    this.rayo.lanzarHabilidad(this.gameObject);
                    animationExit = false;
                    break;
                case "r":
                    
                    animationExit = false;
                    break;
            }
        }
    }

}
