using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private static PlayerScript _instance = null;
    public static PlayerScript Instance() { return _instance; }

    private int max_character = 5;
    public List<CharacterScript> characterList = new List<CharacterScript>();

    public void SetMaxCharacter(int max_character) { this.max_character = max_character; }
    public int GetMaxCharacter() { return max_character; }

    void Awake()
    {
        if (_instance == null)
            _instance = this;

        DontDestroyOnLoad(this);
    }
}