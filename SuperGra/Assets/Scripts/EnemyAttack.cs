using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;
    public int attackDmg = 25;
    GameObject player;
    PlayerHealth playerHealth;
    bool playerInRange;
    float timer;

	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        Debug.Log(player);
	}
	
	void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange)
        {
            Attack();
            timer = 0f;
        }
        
        
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            playerInRange = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == player)
        {
            playerInRange = false;
        }
    }

    void Attack()
    {
        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(attackDmg);
        }
    }
}
