using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using System;

public class GestureCatcher : MonoBehaviour
{
    public double PositionThreshold = 0.1;
    public double RotationThreshold = 10;
    HandComparison handComp;

    // Use this for initialization
    void Start()
    {
        this.handComp = new HandComparison(PositionThreshold, RotationThreshold);
    }

    // Update is called once per frame
    void Update()
    {
        RigidHand[] handsCatcher = (RigidHand[])GameObject.FindObjectsOfType(typeof(RigidHand));
        LeapHand[] hands = GetComponent<HandRegister>().hands;

        foreach (RigidHand hand in handsCatcher)
        {
            LeapHand lHand = new LeapHand(hand);

            foreach (LeapHand savedHand in hands)
            {
                if (savedHand.handedness == lHand.handedness)
                {
                    if (handComp.compareHand(savedHand, lHand))
                    {
                        Debug.Log("ITS ALIVE");
                    }
                }
            }
        }
    }

}
