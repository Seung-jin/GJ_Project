using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagerScript : MonoBehaviour
{
    private static CharacterManagerScript _instance = null;
    public static CharacterManagerScript Instance() { return _instance; }

    public List<CharacterScript> characters = new List<CharacterScript>();

    public void CreateCharacter()
    {
        characters.Add(new Character_Dealer1());
        characters.Add(new Character_Tanker1());
        characters.Add(new Character_Healer1());
    }

    void Awake()
    {
        if (_instance == null)
            _instance = this;
    }

    void Start()
    {
        CreateCharacter();
    }
}