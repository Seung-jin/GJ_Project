using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {
    public int max_hp;
    public int cur_hp;
    public int normal_attack;
    public List<CharacterSkillScript> skillList;
    public string cha_name;
    public Grade grade;
}

public enum Grade
{
    First = 1,
    Second,
    Third,
}