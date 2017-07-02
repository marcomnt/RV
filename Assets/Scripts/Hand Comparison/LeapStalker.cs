using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class LeapStalker : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RigidHand[] hands = (RigidHand[])GameObject.FindObjectsOfType(typeof(RigidHand));
        foreach (RigidHand hand in hands)
        {
            Debug.Log(
            "hand: " + hand.Handedness + " - " +
            "hand: " + hand.GetPalmPosition() + " - "
            );

            foreach (var finger in hand.fingers)
            {
                Debug.Log(finger.fingerType + ": ");
                foreach (Transform joint in finger.bones)
                {
                    if(joint != null)
                        Debug.Log(joint.rotation + " - ");
                }
            }
            Debug.Log("--------------------------------");
        }

    }
}
