using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Text deathText;

    bool isDead;
    bool damaged;

	void Awake () {
        currentHealth = startingHealth;
        healthSlider.value = CalculateHealth();
    }
	int CalculateHealth()
    {
        return currentHealth / startingHealth;
       
    }
	void Update ()
    {
        healthSlider.value = (currentHealth * 1.0f  / startingHealth);        //Jeszcze trzeba bedzie polaczyc to w jakim momencie gracz dostaje DMG
	}

    public void TakeDamage (int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }
    void Death()
    {
        isDead = true;
        deathText.text = "YOU DEAD SON";
    }
}
