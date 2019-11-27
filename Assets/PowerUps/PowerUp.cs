using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    protected bool available = true;
    private bool active = false;
    public float spawnTime = 10f;
    protected GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    virtual protected void UsePowerUp()
    {
    }

    protected void RespawnPowerUp()
    {
        available = true;
    }

    virtual protected void PowerUpExpired()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && available)
        {
            UsePowerUp();
        }
    }
}
