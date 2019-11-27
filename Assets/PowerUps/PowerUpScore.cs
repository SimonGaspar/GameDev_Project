﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScore : PowerUp
{
    [Range(1.0f, 2.0f)]
    public float scoreMultiplier = 2.0f;

    private static bool active = false;

    protected override void UsePowerUp()
    {
        base.UsePowerUp();
        active = true;
        CompleteProject.ScoreManager.scoreMul = scoreMultiplier;
    }

    protected override void PowerUpExpired()
    {
        base.PowerUpExpired();
        active = false;
        CompleteProject.ScoreManager.scoreMul = 1;
    }
    override protected bool CanBeUsed() { return !active; }
}
