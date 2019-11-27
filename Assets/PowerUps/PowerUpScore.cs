using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScore : PowerUp
{
    [Range(1.0f, 2.0f)]
    public float scoreMultiplier = 2.0f;

    protected override void UsePowerUp()
    {
        base.UsePowerUp();
        CompleteProject.ScoreManager.scoreMul = scoreMultiplier;
    }

    protected override void PowerUpExpired()
    {
        base.PowerUpExpired();
        CompleteProject.ScoreManager.scoreMul = 1;
    }
}
