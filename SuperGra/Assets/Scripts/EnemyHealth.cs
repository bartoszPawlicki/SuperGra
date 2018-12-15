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
    public Cooldown hitCooldown;

    void Start ()
    {
        CurrentHealth = StartingHealth;
        particles = GetComponentInChildren<ParticleSystem>();
        hitCooldown.InitCooldown();
    }
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            if(hitCooldown.canUse)
            {
                hitCooldown.startTimer();
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
}
