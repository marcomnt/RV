using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class HandRegister : MonoBehaviour {

    public KeyCode registerKey = KeyCode.Space;
    public LeapHand[] hands = new LeapHand[0];

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(registerKey))
        {
            RigidHand[] handsCatcher = (RigidHand[])GameObject.FindObjectsOfType(typeof(RigidHand));
            this.hands = new LeapHand[handsCatcher.Length];
            for (int i = 0; i < handsCatcher.Length; i++)
            {
                this.hands[i] = new LeapHand(handsCatcher[i]);
            }
        }
	}
}
