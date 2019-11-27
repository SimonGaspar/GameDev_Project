﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    protected bool available = true;
    protected GameObject player;
    [SerializeField]
    private float spawnTime = 20f;
    [SerializeField]
    private float duration = 5f;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    virtual protected void UsePowerUp() { }
    virtual protected void PowerUpExpired() { }  

    private IEnumerator PowerUpRespawnTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        available = true;
        //TODO desaturate material
    }

    private IEnumerator PowerUpDurationTimer()
    {
        yield return new WaitForSeconds(duration);
        PowerUpExpired();
    }   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && available)
        {
            //TODO do not use when another power up is active or if player has full health
            UsePowerUp();
            available = false;
            if (duration > 0)
            {
                StartCoroutine(PowerUpDurationTimer());
            }
            StartCoroutine(PowerUpRespawnTimer());
        }
    }
}
