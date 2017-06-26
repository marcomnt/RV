using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour {

    Dicionario dicionario;
    string estado;
    Gesto Gcaptura;
    Acao Acaptura;
	// Use this for initialization
	void Start () {
        dicionario = new Dicionario();
        Gcaptura = new Gesto();
        Acaptura = new Acao();
        estado = "neutro";
	}
	
	// Update is called once per frame
	void Update () {
        if (estado == "neutro") {
            if (Input.GetKeyDown(KeyCode.F1)) //Cadastrar novo gesto e nova acão
            {
                estado = "cadastrandoGesto";
            }
            else if (Input.GetKeyDown(KeyCode.F2)) //Consultar
            {
                estado = "capturandoGesto";
            }
        }
        if(estado == "capturandoGesto")
        {
            Gcaptura.capturar();
            if (Gcaptura.ended())
            {
               (dicionario.consultar(Gcaptura)).realizar();
                Acaptura.clear();
                Gcaptura.clear();
                estado = "neutro";
            }
        }
        if (estado == "cadastrandoGesto")
        {
            Gcaptura.capturar();
            if (Gcaptura.ended())
            {
                estado = "capturarAcao";
            }
        }
        if (estado == "capturarAcao")
        {
            Acaptura.capturar();
            if (Acaptura.ended())
            {
                dicionario.cadastrar(Gcaptura, Acaptura);
                Gcaptura.clear();
                Acaptura.clear();
                estado = "neutro";
            }
        }



    }
}

