using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class LeapHand
{
    public Chirality handedness;
    public Guidance palm;
    public Guidance forearm;
    public Guidance[] fingers;
    public Guidance elbowJoint;

    public LeapHand(RigidHand hand)
    {
        this.palm = new Guidance(hand.palm);
        this.forearm = new Guidance(hand.forearm);
        this.elbowJoint = new Guidance(hand.elbowJoint);

        FingerModel[] fingersModel = hand.fingers;
        this.fingers = new Guidance[fingersModel.Length];
        for (int i = 0; i < fingersModel.Length; i++)
        {
            this.fingers[i] = new Guidance(fingersModel[i].transform);
        }

        this.handedness = hand.Handedness;
    }
}
