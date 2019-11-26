using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantMine : MonoBehaviour
{
    [SerializeField]
    private GameObject Mine = null;
    public float timeBetweenMines;     // The time between each shot.

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        // If the Fire1 button is being press and it's time to fire...
        if (Input.GetButton("Fire2") && timer >= timeBetweenMines && Time.timeScale != 0)
        {
            // ... shoot the gun.
            SetMine();
        }
    }

    private void SetMine()
    {
        timer = 0f;
        Instantiate(Mine, transform.position, transform.rotation);
    }
}
