using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    private Vector3 startPos;
    private float floatDistance;
    public int dir;
    public enum DoorState
    {
        goingUp,
        goingDown,
        stop
    }

    DoorState doorState;
    
	void Start ()
	{
	    doorState = DoorState.stop;
	    startPos = transform.position;
	}
	
	void Update ()
    {
        if (doorState == DoorState.goingUp)
        {
            // logika na podnoszenie drzwi;
                if (transform.position.y < startPos.y - floatDistance)
                {
                    dir = 1;
                    floatDistance = 3;
                }

                if (transform.position.y < 4)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * dir,
                        transform.position.z);
            }
        }
        else if (doorState == DoorState.goingDown)
        {
            // logika na opuszczanie drzwi;
            if (transform.position.y >= startPos.y + floatDistance)
            {
                dir = -1;
                floatDistance = 0;
            }
            if (transform.position.y >= 1)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * dir,
                    transform.position.z);
            } 
        }
        else if (doorState == DoorState.stop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * 0,transform.position.z);
        }
    }

    public void ChangeDoorState(DoorState doorState)
    {
        this.doorState = doorState;
    }
}