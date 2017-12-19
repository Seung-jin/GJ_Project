using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkillScript {
    public SkillType skillType;
    public int damage;
    public int heal;
    public string name;

    /// <summary>
    /// 해당 스킬의 발동 대상을 설정
    /// </summary>
    /// <param name="monsterList"></param>
    public void SelectSkillTarget(List<MonsterScript> monsterList)
    {
        if(skillType.Equals(SkillType.One_Attack))
        {
            //몬스터 선택 화면 띄우고 선택하게 함
        }
        else if(skillType.Equals(SkillType.Multi_Attack))
        {
            //바로 상대 몬스터들 모두를 공격
        }
        else if(skillType.Equals(SkillType.One_Heal))
        {
            //아군 선택 화면 띄우고 선택하게 함
        }
        else if(skillType.Equals(SkillType.Multi_Heal))
        {
            //아군 전체 힐
        }
    }

    /// <summary>
    /// 해당 스킬을 발동
    /// </summary>
    /// <param name="monsterList">적 진영에 있는 몬스터 리스트들</param>
    /// <param name="pos">단 하나만 선택 시 선택된 것의 위치</param>
    public void ActiveSkill(List<MonsterScript> monsterList, int pos)
    {
        if (skillType.Equals(SkillType.One_Attack))
        {
            //몬스터 선택 화면 띄우고 선택하게 함
        }
        else if (skillType.Equals(SkillType.Multi_Attack))
        {
            //바로 상대 몬스터들 모두를 공격
        }
        else if (skillType.Equals(SkillType.One_Heal))
        {
            //아군 선택 화면 띄우고 선택하게 함
        }
        else if (skillType.Equals(SkillType.Multi_Heal))
        {
            //아군 전체 힐
        }
    }
}

public enum SkillType
{
    One_Attack,
    Multi_Attack,
    One_Heal,
    Multi_Heal
}