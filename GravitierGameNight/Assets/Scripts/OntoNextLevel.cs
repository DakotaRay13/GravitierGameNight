//Changes Levels when the Player enters Exit.
//     -Dakota Ray Manley

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OntoNextLevel : MonoBehaviour {

    //Transition Animation
    public Image TempTransition;
    public Animator anim;
    
    //Level to Load
    public string NextLevel;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            //Play Exit Animation

            //Pull up Next Level Button

            //Play Level Transition and Change Scenes
            
            //Change Scenes
            SceneManager.LoadScene(NextLevel);          
        }
    }

        

}
