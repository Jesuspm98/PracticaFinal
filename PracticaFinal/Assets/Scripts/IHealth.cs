using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    public int maxHealth { get; }
    public int currentHealth { get; }

    public void Die();
}