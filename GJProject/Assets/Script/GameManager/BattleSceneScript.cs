using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneScript : MonoBehaviour {
    public List<PlayerBlockScript> playerBlockList;
    PlayerScript playerScript = null;

    void Start()
    {
        playerScript = PlayerScript.Instance();
        print(playerScript.characterList.Count);
        for (int i=0; i<playerScript.characterList.Count; i++)
        {
            playerScript.characterList[i].gameObject.SetActive(true);
        }
    }
}