using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        //anim.SetTrigger("PlayerProximity");
        anim.SetTrigger("OpenDoor");
    }

    private void OnTriggerExit(Collider other)
    {
        //anim.SetTrigger("PlayerProximity");
        anim.SetTrigger("CloseDoor");
    }
}
