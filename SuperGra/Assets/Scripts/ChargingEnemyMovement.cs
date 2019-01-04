using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChargingEnemyMovement : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    public Cooldown chargeCooldown;
    private float chargeTimer = 0;
    private bool chargeUsed = false;
    public float stopTimer = 1.0f;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        chargeCooldown.InitCooldown();
    }

    void Update()
    {
        nav.SetDestination(player.position);
        chargeUsed = false;
        Charge();
        //Exhaustion();
    }

    void Charge()
    {
        if(chargeCooldown.canUse)
        {
            chargeCooldown.startTimer();
            chargeTimer = 0.04f;
        }

        if(chargeTimer > 0)
        {
            chargeTimer -= Time.deltaTime;
            Vector3 pom = player.position;
            nav.SetDestination(pom);
            nav.speed = nav.speed * 3;
        }

        chargeUsed = true;
    }

    void Exhaustion()
    {
        if(chargeUsed == true)
        {
            nav.isStopped = true;
        }

        stopTimer -= Time.deltaTime;

        if(stopTimer == 0)
        {
            nav.isStopped = false;
        }
    }
}
