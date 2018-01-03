using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Healer1 : CharacterScript
{

    public Character_Healer1()
    {
        max_hp = 15;
        cur_hp = this.max_hp;
        normal_attack = 3;
        cha_name = "Healer1";
        grade = Grade.FIRST;

        skillList.Add(new CharacterSkillScript(SkillType.One_Heal, 0, 3, "Heal!!"));
    }
}
