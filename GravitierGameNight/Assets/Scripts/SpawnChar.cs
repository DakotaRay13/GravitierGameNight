//The following script will be called to create the button for 
//the player to press to spawn / respawn the character.
//   -Dakota Ray Manley

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnChar : MonoBehaviour {

    private Vector3 RespawnPoint;
    public GameObject MainCharacter;
    public GameObject RespawnEntrance;
    public Button StartButton;
    public GameObject SBText;   //Will Be Removed when Dedicated Button Sprite is added

    private void Start()
    {
        //Maps character respawn point to the Entrance attached
        RespawnPoint = RespawnEntrance.transform.position;

        Button startButton = StartButton.GetComponent<Button>();
        startButton.onClick.AddListener(StartLevel);
        
    }

    void StartLevel()
    {
        //Destroy button
        Destroy(StartButton);
        Destroy(StartButton.image);
        Destroy(SBText);
        
        //Do Entrance Animation

        //Spawn Main Character
        MainCharacter.transform.position = RespawnPoint;        
    }


           
        
    
}
