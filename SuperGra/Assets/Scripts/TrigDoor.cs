using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigDoor : MonoBehaviour {
	// Update is called once per frame
	private void OnTriggerEnter(Collider other)
	{
		transform.parent.GetComponent<Door>().ChangeDoorState(Door.DoorState.goingUp);
	}
	void OnTriggerExit(Collider other)
	{
		// logic about what happens when player enters trigger
		transform.parent.GetComponent<Door>().ChangeDoorState(Door.DoorState.goingDown);		
	}
}
