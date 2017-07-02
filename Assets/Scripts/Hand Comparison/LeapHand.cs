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
        if(hand.palm != null)
            this.palm = new Guidance(hand.palm);

        if (hand.forearm != null)
            this.forearm = new Guidance(hand.forearm);

        if (hand.elbowJoint != null)
            this.elbowJoint = new Guidance(hand.elbowJoint);

        FingerModel[] fingersModel = hand.fingers;
        this.fingers = new Guidance[fingersModel.Length, FingerModel.NUM_BONES];
        for (int i = 0; i < fingersModel.Length; i++)
        {
            for (int j = 0; j < FingerModel.NUM_BONES; ++j)
            {
                if(fingersModel[i] != null && fingersModel[i].bones[j] != null)
                    this.fingers[i,j] = new Guidance(fingersModel[i].bones[j]);
            }
        }

        this.handedness = hand.Handedness;
    }
}
