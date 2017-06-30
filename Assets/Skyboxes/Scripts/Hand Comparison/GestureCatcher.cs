using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using System;
using CompleteProject;

public class GestureCatcher : MonoBehaviour
{

    LeapHand[] hands;
    HandComparison handComp;
    CompleteProject.PlayerShooting playershooting;

    //use this for: setar essa porra na tora!
    //public void setaEssaPorra(PlayerShooting ps){
    //    this.playershooting = ps;
    //}

    // Use this for initialization
    void Start()
    {
        this.handComp = new HandComparison(1, 1);
        this.hands = new LeapHand[2];
    }

    private void Awake()
    {
        playershooting = GetComponentInChildren<CompleteProject.PlayerShooting>();
        Debug.Log(this.playershooting);
    }

    // Update is called once per frame
    void Update()
    {
        RigidHand[] handsCatcher = (RigidHand[])GameObject.FindObjectsOfType(typeof(RigidHand));

        foreach (RigidHand hand in handsCatcher)
        {
            LeapHand lHand = new LeapHand(hand);
            if (this.hands[0].handedness == lHand.handedness)
            {
                if (handComp.compareHand(this.hands[0], lHand))
                {
                    this.playershooting.Shoot();
                    Debug.Log("DDDAAALLEEEEE");
                }
            }
            else
            {
                if (handComp.compareHand(this.hands[1], lHand))
                {
                    this.playershooting.Shoot();
                    Debug.Log("EEEEELLAAADDD");
                }
            }
        }
    }

}
