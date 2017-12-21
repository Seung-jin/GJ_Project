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

    public Animation characterAni;
    public AnimationClip attackAniClip;

    void Start()
    {
        IdleAnimation();
    }

    public void IdleAnimation()
    {
        characterAni.Play("idle");
    }


    public void Attack()
    {
        characterAni.Stop();
        characterAni.Play(attackAniClip.name);
        Invoke("IdleAnimation", attackAniClip.length);
    }
}

public enum Grade
{
    FIRST = 1,
    SECOND,
    THIRD,
}