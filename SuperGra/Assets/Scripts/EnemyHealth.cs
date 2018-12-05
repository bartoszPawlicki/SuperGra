using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int StartingHealth;
    private float CurrentHealth;
    GameObject enemy;
    
	void Start ()
    {
        CurrentHealth = StartingHealth; 
	}
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            CurrentHealth -= 25;
            if (CurrentHealth <= 0)
            {
                gameObject.SetActive(false);

            }
        }
    }
}
