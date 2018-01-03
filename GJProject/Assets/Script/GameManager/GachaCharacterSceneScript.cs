using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaCharacterSceneScript : MonoBehaviour
{
    public Text messageText;
    public Text displayText;

    public CharacterManagerScript characterManager;

    public void GachaCharacter()
    {
        if(PlayerScript.Instance().characterList.Count.Equals(PlayerScript.Instance().GetMaxCharacter())) {
            messageText.text = "Character box is filled!!";
        }
        else
        {
            PlayerScript.Instance().characterList.Add(characterManager.characters[Random.Range(0, characterManager.characters.Count)]);
            DisplayCharacterList();
        }
    }

    public void DisplayCharacterList()
    {
        displayText.text = "";
        PlayerScript.Instance().characterList.ForEach(x => displayText.text += (x.cha_name + " "));
    }
}