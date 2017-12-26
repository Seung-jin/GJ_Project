using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Dealer1 : CharacterScript
{
    public Character_Dealer1()
    {
        this.max_hp = 20;
        this.cur_hp = this.max_hp;
        this.normal_attack = 5;
        this.cha_name = "Dealer1";
        this.grade = Grade.FIRST;
    }
}