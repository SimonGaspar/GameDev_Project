using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : PowerUp
{
    private int healthBonus = 33;

    protected override void UsePowerUp() 
    {        
        base.UsePowerUp();

        var playerHealth = player.GetComponent<CompleteProject.PlayerHealth>();
        playerHealth.Heal(healthBonus);
    }
}
