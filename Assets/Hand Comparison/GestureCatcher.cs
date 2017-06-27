using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class GestureCatcher : MonoBehaviour {

    RigidHand[] hands;
    // Use this for initialization
    void Start () {
       RigidHand[] hands = (RigidHand[])GameObject.FindObjectsOfType(typeof(RigidHand));
    }
	
	// Update is called once per frame
	void Update () {
		foreach(RigidHand hand in hands)
        {
            new LeapHand(hand);
        }
    }

}
