using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Vector3 movementVector;                         //Zmienna służąca do poruszania się po wszystkich 3 osiach
    private CharacterController characterController;        //Tworzymy obiekt klasy Character Controller, ktora zostala dodana do obiektu gracza
    public float movementSpeed = 15;
    private float gravity = 100;

    //private Vector3 rotateVector;
    private float rotateSpeed = 90;

    //private Input aimHorizontal = Input.GetAxis("RightJoystickX");


	void Start () {
        characterController = GetComponent<CharacterController>();      //Pobieramy tę dodaną do obiektu klasę
	}
	

	void Update () {
        movementVector.x = Input.GetAxis("LeftJoystickX") * movementSpeed;      //Poruszanie się po osi X, wartość w cudzysłowie pobrana jest z -> Edit/Project Settings/Input
        movementVector.z = Input.GetAxis("LeftJoystickY") * movementSpeed;      //Poruszanie po osi Y
        movementVector.y = 0;

        movementVector.y -= gravity * Time.deltaTime;       //Grawitacja, nie bedziemy się poruszać po osi y, bo raczej u nas skoku nie będzie,
                                                            //ale jeśli teren będzie się obniżał, to nasza postać będzie latać, a tego nie chcemy

        //Vector3 lookDirection = new Vector3(Input.GetAxisRaw("RightJoystickX"), 0, Input.GetAxisRaw("RightJoystickY"));
        //transform.rotation = Quaternion.LookRotation(lookDirection);

        //transform.localEulerAngles = new Vector3(0, (float)(Math.Atan2(Input.GetAxis("RightJoystickX"), Input.GetAxis("RightJoystickY")) * 180 / Math.PI), 0);

        characterController.Move(movementVector * Time.deltaTime);      //.Move jest wbudowane, ta funkcja służy czysto do poruszania się
        



	}
}