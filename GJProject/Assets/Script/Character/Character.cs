using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    public int hp;
    public int normal_attack;
    public List<CharacterSkill> skillList;
    public string cha_name;
    public Grade grade;
}

public enum Grade
{
    First = 1,
    Second,
    Third,
}