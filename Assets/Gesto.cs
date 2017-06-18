using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gesto{
    LeapGesture gestoLeap;
    KinnectGesture gestoKinnect;

    // Use this for initialization
    public Gesto () {
        gestoLeap = new LeapGesture();
        gestoKinnect = new KinnectGesture();
	} 

    public void captura() {
        gestoLeap.capturarLeap();
        gestoKinnect.capturarKinnect();
    }
    public bool ended() {
        return gestoLeap.is_finalizated();
    }
    public void set_gesto(Gesto g) {
        gestoKinnect = g.get_KinnectGesture();
        gestoLeap = g.get_LeapGesture();
    }

    private KinnectGesture get_KinnectGesture(){
        return gestoKinnect;
    }
    private LeapGesture get_LeapGesture()
    {
        return gestoLeap;
    }
}