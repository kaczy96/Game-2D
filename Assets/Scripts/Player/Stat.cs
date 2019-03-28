﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public class Stat
{
    
    [SerializeField]private int baseValue;

    public int GetValue()
    {
        return baseValue;
    }
}
