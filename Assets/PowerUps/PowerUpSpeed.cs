using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUp
{    
        [Range(1.0f, 4.0f)]
        public float speedMultiplier = 2.0f;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerMovement = player.GetComponent<PlayerMovement>();
        }

        protected override void UsePowerUp()          
        {
            base.UsePowerUp();
        playerMovement.SpeedBoostOn(speedMultiplier);
        }

        protected override void PowerUpExpired()      
        {
        playerMovement.SpeedBoostOff();
            base.PowerUpExpired();
        }
}
