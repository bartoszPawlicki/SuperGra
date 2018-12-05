using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    
    public GameObject shootingObject; //z tego wylatuje pocisk
    public GameObject projectile; // pocisk
    public float projectileForce; // sila z jaka wylatuje pocisk z shooting object

    // Korzystamy z poolingu obiektów, żeby nie używać Instantiate w trakcie właściwiej gry.
    public ObjectPool bulletPool;

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

        ////projectile instantiation
        //GameObject tempProjectile;
        //tempProjectile = Instantiate(projectile, shootingObject.transform.position, shootingObject.transform.rotation) as GameObject;

        //Rigidbody tempRigidBody;
        //tempRigidBody = tempProjectile.GetComponent<Rigidbody>();

        ////nadanie sily pociskowi
        //tempRigidBody.AddForce(transform.forward * projectileForce);



        ////zniszczenie pocisku po czasie
        //Destroy(tempProjectile, 3.0f);




        //alternatywna wersja
        GameObject tempProjectile = bulletPool.PoolNext(shootingObject.transform.position);


        // takie rzeczy można w jednej linijce
        Rigidbody tempRigidBody = tempProjectile.GetComponent<Rigidbody>();


        //nadanie sily pociskowi
        tempRigidBody.AddForce(transform.forward * projectileForce);

        // zaczęcie korutnyny. 
        StartCoroutine(DestroyBullet(tempProjectile));

    }

    //Korutyna jest uruchamiana na osobnym wątku, można też wracać do niej po jakimś czasie - coś jak uśpienie fukncji.
    public IEnumerator DestroyBullet(GameObject go)
    {
        yield return new WaitForSeconds(3f); // po 3 sekundach tutaj wrócimy
        go.SetActive(false);

    }
}
