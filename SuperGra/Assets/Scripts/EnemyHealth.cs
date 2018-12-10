using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int StartingHealth;
    private float CurrentHealth;
	public static int remainingEnemies;

	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
		remainingEnemies = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentHealth == 0)
        {
            //Destroy.              DOKONCZYC TU
	        //remainingEnemies--;
        }
	}

    void Damage(Collider projectile)
    {
        if(projectile.gameObject.CompareTag("Projectile"))
        {
            CurrentHealth -= 25;
        }
    }
}
