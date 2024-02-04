using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WObj 
{
    public Vector2 Position;
    public Vector2 Direction;
    public float ChanceToAlter;
    public WObj(Vector2 pos, Vector2 dir, float chanceToAlter)
    {
        Position = pos;
        Direction = dir;
        ChanceToAlter= chanceToAlter;
    }
}
