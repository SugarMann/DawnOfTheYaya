﻿using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Game{

    public int difficulty;
    public int zone;
    public float time;
    public int lifeLost;
    public string language;
    public List<SavedZombie> zombies;
    public SavePlayer player;

}
