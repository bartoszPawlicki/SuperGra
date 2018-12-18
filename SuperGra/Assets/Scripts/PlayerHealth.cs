using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public RawImage greenBarImage;
    public Text deathText;
    ParticleSystem particles;

    bool isDead;
    bool damaged;

	void Awake ()
    {
        currentHealth = startingHealth;
        greenBarImage.rectTransform.localScale = new Vector3(currentHealth * 1.0f / startingHealth, 1f, 1f);
    }

    private void Start()
    {
        particles = GetComponentInChildren<ParticleSystem>();
    }
	void Update ()
    {
            //Jeszcze trzeba bedzie polaczyc to w jakim momencie gracz dostaje DMG

    }

    public void TakeDamage (int amount)
    {
        greenBarImage.rectTransform.localScale = new Vector3(currentHealth * 1.0f / startingHealth, 1f, 1f);
        damaged = true;
        currentHealth -= amount;
        particles.Play();
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }


    }
    void Death()
    {
        greenBarImage.rectTransform.localScale = new Vector3(currentHealth * 1.0f / startingHealth, 1f, 1f);
        gameObject.SetActive(false);
        isDead = true;
        //deathText.text = "YOU DEAD SON";
    }
}
