using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator;
    int estaMoviendoHash;
    int estaCorriendoHash;
    int saltarHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        estaMoviendoHash = Animator.StringToHash("isWalking");
        estaCorriendoHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool pulsarBoton = Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d");
        bool estaMoviendo = animator.GetBool(estaMoviendoHash);
        bool correrPulsado = Input.GetKey("left shift");
        bool estaCorriendo = animator.GetBool(estaCorriendoHash);
        bool pulsarSaltar = Input.GetKey("space");

        if (!estaMoviendo && pulsarBoton)
        {
            animator.SetBool(estaMoviendoHash, true);
        }

        if (estaMoviendo && !pulsarBoton)
        {
            animator.SetBool(estaMoviendoHash, false);
        }

        if (!estaCorriendo && (estaMoviendo && correrPulsado))
        {
            animator.SetBool(estaCorriendoHash, true);
        }

        if(estaCorriendo && (!estaMoviendo || !correrPulsado))
        {
            animator.SetBool(estaCorriendoHash, false);
        }
    }
}
