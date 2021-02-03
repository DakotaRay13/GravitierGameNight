//When Player comes into contact with the Switch, it switches Off
//and "Retracts" the Barriers.
//    -Dakota Ray Manley

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAndBarrierController : MonoBehaviour {

    public Animator SwitchAnim;
    public AnimationClip BarrierOffAnim;
    public int AmmountOfBarriers;
    public GameObject[] Barriers;
    public float DelayNext = 1f;

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.gameObject.tag == "GameController") //"GameController" is the Ball itself
        {
            //Play Switch Animation
            SwitchAnim.SetBool("IsSwitchedOff", true);

            //Call StartBarriers
            //StartCoroutine("StartBarriers");
            StartBarriers();
        }
    }

    //IEnumerator StartBarriers()
    //{
    //    for (int Count = 0; Count < AmmountOfBarriers; Count++)
    //    {
    //        //Wait for DelayNext time (Default a quarter of a second)            
    //        BarrierOff(Barriers[Count]);
    //        yield return new WaitForSeconds(BarrierOffAnim.length);      
    //    }
    //}

    private void StartBarriers()
    {
        for(int Count = 0; Count < AmmountOfBarriers; Count++)
        {
            BarrierOff(Barriers[Count]);
            for(int Frame = 0; Frame > BarrierOffAnim.length; Frame++)
            {
                if(Barriers[Count].GetComponent<Animation>(). IsPlaying("BarrierOff".))
                {
                    return;
                }
            }
        }
    }

    void BarrierOff(GameObject Barrier)
    {
        //Destroy RigidBody2D (Delayed)
        Destroy(Barrier.GetComponent<BoxCollider2D>());

        //Get Animator
        Animator Anim = Barrier.GetComponent<Animator>();
        BarrierOffAnim = Anim.GetComponent<AnimationClip>();
        int Frames = Anim.GetComponent<AnimationClip>().name("BarrierOff") ;
        //Play BarrierOff Animation
        Anim.SetBool("IsSwitchedOff", true);
    }
}
