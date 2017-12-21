using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
    public PlayerScript playerScript;
    public MonsterScript monster;
    public SelectCharacterScript selectCharacterScript;

    void Start()
    {
        //캐릭터 생성하기
        //시작 시 4개의 캐릭터를 선택하게 하여 playerscript에 저장하기
        playerScript.characterList.Clear();
        selectCharacterScript.playerScript = playerScript;
        selectCharacterScript.gameObject.SetActive(true);
    }


}