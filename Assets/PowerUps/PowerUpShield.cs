using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShield : PowerUp
{
    private static bool active = false;
    protected override void UsePowerUp()
    {
        base.UsePowerUp();
        active = true;
        player.GetComponent<CompleteProject.PlayerHealth>().ShieldOn();
    }

    protected override void PowerUpExpired()
    {
        base.PowerUpExpired();
        active = false;
        player.GetComponent<CompleteProject.PlayerHealth>().ShieldOff();
    }

    override protected bool CanBeUsed() { return !active; }
}
