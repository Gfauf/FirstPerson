using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    Animator doorAnimator;

    // Start is called before the first frame update
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HUD.enemyKills >= 5)
        {
            doorAnimator.SetBool("Open", true);
        }
    }

}
