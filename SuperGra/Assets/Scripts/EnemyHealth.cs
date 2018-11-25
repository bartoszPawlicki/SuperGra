using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int StartingHealth;
    private float CurrentHealth;
    GameObject enemy;

	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth; 
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentHealth == 0)
        {
            //Destroy.              DOKONCZYC TU
            
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
