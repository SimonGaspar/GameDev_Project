using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUp
{    
        [Range(1.0f, 4.0f)]
        public float speedMultiplier = 2.0f;

    private static bool active = false;

        protected override void UsePowerUp()          
        {
            base.UsePowerUp();
        active = true;
            player.GetComponent<CompleteProject.PlayerMovement>().SpeedBoostOn(speedMultiplier);
        }

        protected override void PowerUpExpired()      
        {
            base.PowerUpExpired();
        active = false;
            player.GetComponent<CompleteProject.PlayerMovement>().SpeedBoostOff();           
        }

    override protected bool CanBeUsed() { return !active; }
}
