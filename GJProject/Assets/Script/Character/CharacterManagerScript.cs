using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagerScript : MonoBehaviour {
    public static CharacterManagerScript _instance = null;
    public static CharacterManagerScript Instance() { return _instance; }

    public List<CharacterScript> characters = new List<CharacterScript>();

    public void CreateCharacter()
    {
        characters.Add(new Character_Dealer1());
    }

    void Start()
    {
        CreateCharacter();
        print(characters[0].skillList[0].name);
    }
}