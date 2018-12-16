using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    
    public GameObject shootingObject; //z tego wylatuje pocisk
    public GameObject projectile; // pocisk
    public float projectileForce; // sila z jaka wylatuje pocisk z shooting object

    // Korzystamy z poolingu obiektów, żeby nie używać Instantiate w trakcie właściwiej gry.
    public ObjectPool bulletPool;
    public Cooldown attackCooldown;

    Reloading reloading;


	// Use this for initialization
	void Start ()
    {
        attackCooldown.InitCooldown();
        reloading = GetComponent<Reloading>();

    }
	
	// Update is called once per frame
	void Update () {
        
        if (attackCooldown.canUse && Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
		
	}
    //metoda strzelania
    void Shoot()
    {
        if(reloading.canFire)
        {
            reloading.ammoInMagazine--;
            //alternatywna wersja
            GameObject tempProjectile = bulletPool.PoolNext(shootingObject.transform.position);


            // takie rzeczy można w jednej linijce
            Rigidbody tempRigidBody = tempProjectile.GetComponent<Rigidbody>();


            //nadanie sily pociskowi
            tempRigidBody.AddForce(transform.forward * projectileForce);

            // zaczęcie korutnyny. 
            StartCoroutine(DestroyBullet(tempProjectile));

            attackCooldown.startTimer();
        }  
    }

    //Korutyna jest uruchamiana na osobnym wątku, można też wracać do niej po jakimś czasie - coś jak uśpienie fukncji.
    public IEnumerator DestroyBullet(GameObject go)
    {
        yield return new WaitForSeconds(3f); // po 3 sekundach tutaj wrócimy
        go.SetActive(false);

    }
}
