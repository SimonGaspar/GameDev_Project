using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShield : PowerUp
{
    protected override void UsePowerUp()
    {
        base.UsePowerUp();
        player.GetComponent<CompleteProject.PlayerHealth>().ShieldOn();
    }

    protected override void PowerUpExpired()
    {
        base.PowerUpExpired();
        player.GetComponent<CompleteProject.PlayerHealth>().ShieldOff();
    }
}
