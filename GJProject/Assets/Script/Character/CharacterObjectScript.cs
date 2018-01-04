using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterObjectScript : MonoBehaviour {
    public CharacterScript character;

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
