using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigCloseDoor : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.parent.GetComponent<DoorController>().ChangeDoorState(DoorController.DoorState.movingDown);
        }
    }
}
