﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneScript : MonoBehaviour {

    void Start()
    {
        for(int i=0; i<PlayerScript.Instance().characterList.Count; i++)
        {
            print(PlayerScript.Instance().characterList[i].cha_name);
        }
    }
}