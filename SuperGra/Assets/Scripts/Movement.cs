using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Vector3 movementVector;
    private CharacterController characterController;
    private float movementSpeed = 15;


	void Start () {
        characterController = GetComponent<CharacterController>();
	}
	

	void Update () {

        //movementVector.x = Input.GetAxis("Horizontal") * movementSpeed;
        //movementVector.z = Input.GetAxis("Vertical") * movementSpeed;
        movementVector.x = Input.GetAxis("LeftJoystickX") * movementSpeed;
        movementVector.z = Input.GetAxis("LeftJoystickY") * movementSpeed;
        movementVector.y = 0;

        characterController.Move(movementVector * Time.deltaTime);
	}
}