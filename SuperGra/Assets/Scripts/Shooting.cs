using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    
    public GameObject shootingObject; //z tego wylatuje pocisk
    public GameObject projectile; // pocisk
    public float projectileForce; // sila z jaka wylatuje pocisk z shooting object

	// Use this for initialization
	void Start () {
		// tu chyba nic nie potrzebujemy wiec nawet by chyba moznaby to usunac nie?
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
		
	}
    //metoda strzelania
    void Shoot()
    {

        //projectile instantiation
        GameObject tempProjectile;
        tempProjectile = Instantiate(projectile, shootingObject.transform.position, shootingObject.transform.rotation) as GameObject;

        Rigidbody tempRigidBody;
        tempRigidBody = tempProjectile.GetComponent<Rigidbody>();

        //nadanie sily pociskowi
        tempRigidBody.AddForce(transform.forward * projectileForce);

   

        //zniszczenie pocisku po czasie
        Destroy(tempProjectile, 3.0f);

    }
}
