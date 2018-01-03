using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Tanker1 : CharacterScript
{
    public Character_Tanker1()
    {
        max_hp = 50;
        cur_hp = this.max_hp;
        normal_attack = 3;
        cha_name = "Tanker1";
        grade = Grade.FIRST;

        skillList.Add(new CharacterSkillScript(SkillType.One_Attack, 5, 0, "Shield!!"));
    }
}
