using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativ : MonoBehaviour {
    private GameObject objeto;
    public bool ativo=false;
	// Use this for initialization
	void Start () {
        objeto = GameObject.Find("BasicFire");
        if (objeto!= null)
        {
            //Debug.Log("ok");
        }
        else
        {
            Debug.Log("OPS");
        }
        objeto.SetActive(ativo);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void on()
    {
        ativo = true;
        objeto.SetActive(ativo);
    }

    public void off()
    {
        ativo = false;
        objeto.SetActive(ativo);
    }
}
