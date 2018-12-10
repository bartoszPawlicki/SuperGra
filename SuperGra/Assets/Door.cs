using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public enum DoorState
    {
        goingUp,
        goingDown,
        stopped
    }

    DoorState doorState;
    
	void Start ()
    {

	}
	
	void Update ()
    {
		if(doorState == DoorState.goingUp)
        {
            // logika na podnoszenie drzwi;
        }
        else if (doorState == DoorState.goingDown)
        {
            // logika na opuszczanie drzwi;
        }
        else if (doorState == DoorState.stopped)
        {

        }

    }

    public void ChangeDoorState(DoorState doorState)
    {
        this.doorState = doorState;
    }
}
