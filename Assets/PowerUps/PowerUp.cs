using System.Collections;
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
    [SerializeField]
    private Color color;

    protected void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameObject.GetComponentInChildren<Renderer>().material.color = color;
    }
    virtual protected void UsePowerUp() {
        gameObject.GetComponentInChildren<Renderer>().material.color = Color.white;
    }
    virtual protected void PowerUpExpired() {
    }  

    virtual protected bool CanBeUsed() { return true; }

    private IEnumerator PowerUpRespawnTimer()
    {
        yield return new WaitForSeconds(spawnTime);
        available = true;
        gameObject.GetComponentInChildren<Renderer>().material.color = color;
    }

    private IEnumerator PowerUpDurationTimer()
    {
        yield return new WaitForSeconds(duration);
        PowerUpExpired();
    }   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && available && CanBeUsed())
        {
            //TODO do not use when another power up of the same type is active or if player has full health
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
