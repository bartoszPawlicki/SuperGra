using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigClose : MonoBehaviour
{

	GameObject drzwi = GameObject.Find("InvTrig");
	public Open Trigger;

	void OnTriggerExit(Collider other)
	{
        // logic about what happens when player enters trigger

        //transform.parent.GetComponent<Door>().ChangeDoorState( );


        if (Trigger.transform.position.y >= Trigger.startPos.y + Trigger.floatDistance)
		{
			Trigger.dir = -1;
			Trigger.floatDistance = 0;
		}
		Trigger.transform.position = new Vector3(Trigger.transform.position.x, Trigger.transform.position.y +Time.deltaTime * Trigger.dir,
			Trigger.transform.position.z);
	}
}