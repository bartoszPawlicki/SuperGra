﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Vector3 movementVector;                         //Zmienna służąca do poruszania się po wszystkich 3 osiach
    private CharacterController characterController;        //Tworzymy obiekt klasy Character Controller, ktora zostala dodana do obiektu gracza
    private float rotateSpeed = 90;
    private float gravity = 100;
    private float rotationX;
    private float rotationY;
    private bool check1 = true;
    private bool check2 = true;

    public float movementSpeed = 15;
    public float rotationSpeed = 10;
    public float mouseSensitivity = 2.0f;
    public float joystickDeadZone = 0.2f;
    public float joystickSensitivity = 1.0f;

    public ChangeInput changeInput;

    void Start ()
    {
        characterController = GetComponent<CharacterController>();      //Pobieramy tę dodaną do obiektu klasę
    }
	

	void Update ()
    {
        movementVector.x = Input.GetAxis("Horizontal") * movementSpeed;      //Poruszanie się po osi X, wartość w cudzysłowie pobrana jest z -> Edit/Project Settings/Input
        movementVector.z = Input.GetAxis("Vertical") * movementSpeed;      //Poruszanie po osi Y
        movementVector.y = 0;

        movementVector.y -= gravity * Time.deltaTime;       //Grawitacja, nie bedziemy się poruszać po osi y, bo raczej u nas skoku nie będzie,
                                                            //ale jeśli teren będzie się obniżał, to nasza postać będzie latać, a tego nie chcemy

       
        if(changeInput.isMouseOn)
        {
            mouseRotation();
        }
        else 
        {
            padRotation();
        }

        characterController.Move(movementVector * Time.deltaTime);      //.Move jest wbudowane, ta funkcja służy czysto do poruszania się
    }

    private void mouseRotation()
    {
        rotationX = Input.mousePosition.x * mouseSensitivity;
        rotationY = Input.mousePosition.y * mouseSensitivity;

        Vector3 mouse_pos = Input.mousePosition;
        Vector3 object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        float angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, -angle+75, 0));

    }

    private void padRotation()
    {
        rotationX = Input.GetAxis("RightJoystickX") * joystickSensitivity;
        rotationY = Input.GetAxis("RightJoystickY");

        if (rotationX != 0)     //To jest część, która sprawiła, ze obrót postaci nie wraca do miejsca początkowego
        {
            Vector3 lookDirection = new Vector3(rotationX, 0, rotationY);
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}