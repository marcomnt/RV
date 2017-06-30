using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class LeapHand
{
    public Chirality handedness;
    public Guidance palm;
    public Guidance forearm;
    public Guidance[,] fingers;
    public Guidance elbowJoint;

    public LeapHand(RigidHand hand)
    {
        this.palm = new Guidance(hand.palm);
        this.forearm = new Guidance(hand.forearm);
        this.elbowJoint = new Guidance(hand.elbowJoint);

        FingerModel[] fingersModel = hand.fingers;
        this.fingers = new Guidance[fingersModel.Length, FingerModel.NUM_JOINTS];
        for (int i = 0; i < fingersModel.Length; i++)
        {
            for (int j = 0; j<=3; ++j)
            {
                this.fingers[i,j] = new Guidance(fingersModel[i].joints[j]);
            }
        }

        this.handedness = hand.Handedness;
    }
}
