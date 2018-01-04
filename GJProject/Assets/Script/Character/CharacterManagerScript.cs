using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagerScript : MonoBehaviour
{
    private static CharacterManagerScript _instance = null;
    public static CharacterManagerScript Instance() { return _instance; }

    //characterObjectScript로 변경할 것
    public List<CharacterScript> characters = new List<CharacterScript>();

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        DontDestroyOnLoad(this);
    }
}