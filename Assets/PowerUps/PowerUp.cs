using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    protected bool available = true;
    private bool active = false;
    public float spawnTime = 20f;
    protected GameObject player;
    public float duration = 5f;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    virtual protected void UsePowerUp() { }
    virtual protected void PowerUpExpired() { Debug.Log("expired"); }  

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
