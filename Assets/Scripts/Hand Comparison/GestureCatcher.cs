using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using System;

public class GestureCatcher : MonoBehaviour {

    LeapHand[] hands;
    HandComparison handComp;

    // Use this for initialization
    void Start () {
        this.handComp = new HandComparison(1, 1);
        this.hands = new LeapHand[2];
        //
    }
	
	// Update is called once per frame
	void Update () {
        RigidHand[] handsCatcher = (RigidHand[])GameObject.FindObjectsOfType(typeof(RigidHand));

        foreach (RigidHand hand in handsCatcher)
        {
            LeapHand lHand = new LeapHand(hand);
            if (this.hands[0].handedness == lHand.handedness)
            {
                if (handComp.compareHand(this.hands[0], lHand))
                {
                    Console.WriteLine("DDDAAALLEEEEE");
                }
            } else
            {
                if (handComp.compareHand(this.hands[1], lHand))
                {
                    Console.WriteLine("EEEEELLAAADDD");
                }
            }
        }
    }

}
