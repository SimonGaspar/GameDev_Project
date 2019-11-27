using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpShield : PowerUp
{
    private static bool active = false;
    private Image shieldImage;

    private void Awake()
    {
        base.Awake();
        GameObject imageObject = GameObject.FindGameObjectWithTag("ShieldImage");

        if (imageObject != null)
        {
            shieldImage = imageObject.GetComponent<Image>();
        }
        shieldImage.enabled = false;
    }

    protected override void UsePowerUp()
    {
        base.UsePowerUp();
        active = true;
        shieldImage.enabled = true;
        player.GetComponent<CompleteProject.PlayerHealth>().ShieldOn();
    }

    protected override void PowerUpExpired()
    {
        base.PowerUpExpired();
        active = false;
        shieldImage.enabled = false;
        player.GetComponent<CompleteProject.PlayerHealth>().ShieldOff();
    }

    override protected bool CanBeUsed() { return !active; }
}
