using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IHealth
{
    public int maxHealth { get; }
    public int currentHealth { get; }

    public void TakeDamage(int damageTaken);

    public void Die();
}