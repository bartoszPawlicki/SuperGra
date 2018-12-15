using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int StartingHealth;
    private float CurrentHealth;
    GameObject enemy;
    public Room parentRoom;
    
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
                //Destroy(gameObject);
                parentRoom.enemies.Remove(gameObject);
                gameObject.SetActive(false);
            }
        }
    }
}
