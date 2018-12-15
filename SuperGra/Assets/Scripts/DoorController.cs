using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public enum DoorState
    {
        movingUp,
        movingDown,
        stopped
    }
    public DoorState doorState;
	// Use this for initialization
	void Start ()
    {
        doorState = DoorState.stopped;

    }
	
	// Update is called once per frame
	void Update ()
    {
		switch(doorState)
        {
            case DoorState.movingUp:
                if (transform.position.y < 5)
                {
                    transform.position += Vector3.up * Time.deltaTime;
                }
                break;
            case DoorState.movingDown:
                if (transform.position.y > 1)
                {
                    transform.position += Vector3.down * Time.deltaTime;
                }
                break;
        }
	}

    public void ChangeDoorState(DoorState doorState)
    {
        this.doorState = doorState;
    }
}
