using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject powerUp;                
    public Transform[] spawnPoints;         
    
    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(powerUp, spawnPoints[i].position, spawnPoints[i].rotation);
        }
    }
}