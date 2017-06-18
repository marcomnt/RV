using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour {

    Dicionario dicionario;
	// Use this for initialization
	void Start () {
        dicionario = new Dicionario();
	}
	
	// Update is called once per frame
	void Update () {
           
	}

    void cadastro(Gesto gestos){
        
    }

    void renomear(Gesto seq,Acao ato){
        //string temp="";
        //Debug.Log(string.Concat("Esse gestos fazem a acao: ", ato.get_acao()));
        //Debug.Log("Deseja trocar a acao? (Y/N)");
        //if (Input.GetKeyDown(KeyCode.Y))
        //{
        //    Debug.Log("Escreva a acao e aperte enter ao terminar");
        //    while (!Input.GetKeyDown(KeyCode.KeypadEnter))
        //    {
        //        string.Concat(temp, Input.inputString);
        //    }
        //    ato.set_acao(temp);
        //    dicionario.Rename(gestos, ato);
        //    Debug.Log("Pronto");
        //}
        //else
        //{
        //    Debug.Log("Entao... falou");
        //}
    }
}

