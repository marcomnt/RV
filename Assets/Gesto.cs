using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gesto{
    LeapGesture gestoLeap;

    // Use this for initialization
    public Gesto () {
        gestoLeap = new LeapGesture();
	} 

    public LeapGesture capturar() {
        gestoLeap.capturarLeap();
        if (ended())
        {
            return gestoLeap;
        }
        else { return null; }
    }

    public bool ended()
    {
        return gestoLeap.is_ended();
    }

     public void clear()
    {
        gestoLeap.clear();
    }
}