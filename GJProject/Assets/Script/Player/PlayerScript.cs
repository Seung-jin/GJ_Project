using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public static PlayerScript _instance = null;
    public static PlayerScript Instance() { return _instance; }

    void Start()
    {
        if (_instance == null)
            _instance = this;
    }

    public List<CharacterScript> characterList;
    public List<PlayerBlockScript> blockList;
}