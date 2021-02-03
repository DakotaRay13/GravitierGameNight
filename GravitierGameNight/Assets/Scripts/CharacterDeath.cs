//Reads when player enters a Hazzard trigger
//      -Dakota Ray Manley

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour {

    public string RestartLevel;

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            //Play Death Animation

            //Add 1 to Death Counter (OPTIONAL)

            //Reload Level
            SceneManager.LoadScene(RestartLevel);
        }
    }
}
