using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int StartingHealth;
    private float CurrentHealth;
    GameObject enemy;
    public Room parentRoom;
    ParticleSystem particles;

    void Start ()
    {
        CurrentHealth = StartingHealth;
        particles = GetComponentInChildren<ParticleSystem>();
    }
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            particles.Play();
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
