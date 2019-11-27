using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : PowerUp
{
    [SerializeField]
    private int healthBonus = 25;

    protected override void UsePowerUp() 
    {        
        base.UsePowerUp();

        var playerHealth = player.GetComponent<CompleteProject.PlayerHealth>();
        playerHealth.Heal(healthBonus);
    }
}
