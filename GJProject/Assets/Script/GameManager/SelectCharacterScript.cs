using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacterScript : MonoBehaviour {
    public PlayerScript playerScript;
    public List<CharacterScript> canSelectCharacter;

    private const int maxSelect = 5;
    private int count;

    void Start()
    {
        count = 0;
    }

    public void SelectCharacter(int num)
    {
        playerScript.characterList.Add(canSelectCharacter[num]);
        count++;

        if (count.Equals(maxSelect))
        {
            gameObject.SetActive(false);
        }
    }
}
