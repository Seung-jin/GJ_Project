using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public int max_hp;
    public int cur_hp;
    public int normal_attack;

    public string cha_name;

    void Start()
    {
        cur_hp = max_hp;
    }
}