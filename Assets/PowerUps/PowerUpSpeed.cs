using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUp
{    
        [Range(1.0f, 4.0f)]
        public float speedMultiplier = 2.0f;

        protected override void UsePowerUp()          
        {
            base.UsePowerUp();
            player.GetComponent<CompleteProject.PlayerMovement>().SpeedBoostOn(speedMultiplier);
        }

        protected override void PowerUpExpired()      
        {
            base.PowerUpExpired();
            player.GetComponent<CompleteProject.PlayerMovement>().SpeedBoostOff();           
        }
}
