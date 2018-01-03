using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Dealer1 : CharacterScript
{
    public Character_Dealer1()
    {
        max_hp = 20;
        cur_hp = this.max_hp;
        normal_attack = 5;
        cha_name = "Dealer1";
        grade = Grade.FIRST;

        skillList.Add(new CharacterSkillScript(SkillType.One_Attack, 5, 0, "Attack!!"));
    }
}