using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public CharacterListScript characterListScript;
    public MonsterScript monster;
    public SelectCharacterScript selectCharacterScript;

    void Start()
    {
        characterListScript = new CharacterListScript();
        characterListScript.characterList.Add(new Character_Dealer1());
    }


}