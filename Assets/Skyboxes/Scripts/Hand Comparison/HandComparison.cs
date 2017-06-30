using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap;

public class HandComparison
{
    double thresholdPosition;
    double thresholdAngle;

    List<Chirality> handsVerify;

    bool forearmVerify;
    bool palmVerify;
    bool elbowJointVerify;
    bool[] fingersVerify;

    public HandComparison(double thresholdPosition, double thresholdAngle)
    {
        this.thresholdPosition = thresholdPosition;
        this.thresholdAngle = thresholdAngle;
        this.handsVerify = new List<Chirality>()
        {
            Chirality.Left,
            Chirality.Right
        };
        this.forearmVerify = false;
        this.palmVerify = false;
        this.elbowJointVerify = false;

        this.fingersVerify = new bool[5]
        {
            true,
            true,
            true,
            true,
            true
        };
    }

    public HandComparison(double thresholdPosition, double thresholdAngle, Chirality[] handsVerify, 
        bool forearmVerify, bool palmVerify, bool elbowJointVerify, bool[] fingersVerify)
    {
        this.thresholdPosition = thresholdPosition;
        this.thresholdAngle = thresholdAngle;
        this.handsVerify = new List<Chirality>(handsVerify);
        this.forearmVerify = forearmVerify;
        this.palmVerify = palmVerify;
        this.elbowJointVerify = elbowJointVerify;
        this.fingersVerify = fingersVerify;
    }

    // assume the current and saved LeapHand has the same Chirality
    public bool compareHand(LeapHand current, LeapHand saved)
    {
        bool result = true;

        if (this.handsVerify.Contains(current.handedness) && this.handsVerify.Contains(saved.handedness))
        {
            if (this.forearmVerify)
            {
                result = result && compareGuidanceWithTHreshold(current.forearm, saved.forearm);
            }

            if (this.palmVerify)
            {
                result = result && compareGuidanceWithTHreshold(current.palm, saved.palm);
            }

            if (this.elbowJointVerify)
            {
                result = result && compareGuidanceWithTHreshold(current.elbowJoint, saved.elbowJoint);
            }

            // fingersVerify length can launch exception
            for (int i = 0; i < fingersVerify.Length; i++)
            {
                for (int j=0; j<=3; ++j)
                {
                    if (fingersVerify[i])
                    {
                        result = result && compareGuidanceWithTHreshold(current.fingers[i, j], saved.fingers[i, j]);
                    }
                }
            }
        }


        return result;
    }

    bool compareGuidanceWithTHreshold(Guidance p1, Guidance p2)
    {
        return compareVector3WithThreshold(p1.position, p2.position, thresholdPosition) &&
            compareQuaternionWithThreshold(p1.rotation, p2.rotation, thresholdAngle);
    }

    bool compareVector3WithThreshold(Vector3 p1, Vector3 p2, double threshold)
    {
        double distance = Vector3.Distance(p1, p2);
        return distance <= threshold;
    }

    bool compareQuaternionWithThreshold(Quaternion p1, Quaternion p2, double threshold)
    {
        double angle = Quaternion.Angle(p1, p2);
        return angle <= threshold;
    }

    private bool equateWithThreshold(double p1, double p2, double threshold)
    {
        return (p1 + threshold >= p2 && p1 <= p2) || (p1 - threshold <= p2 && p1 >= p2);
    }
}
