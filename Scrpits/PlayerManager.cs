using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
    public static float firingSpeed = 0.5f;
    public static int gunDamage = 1;

    public static int Health = 10;
    public static int humanity = 100;
    public static float moveSpeed = 2f;

    //upgrades
    public static bool cybEyes = false;
    public static bool handCannon = false;
}
public enum Stats
{
    firerate,
    health,
    speed,
    stamina,
    upgrade
}
