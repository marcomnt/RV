using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dicionario {
    Dictionary<Gesto, Acao> dicionario;
    private Gesto gesto;
    private Acao acao;
    // Use this for initialization
    public Dicionario () {
        dicionario = new Dictionary< Gesto,Acao>();
	}
    
    public void consultar(Gesto g){
        if(dicionario.TryGetValue(g,out acao)){
            acao.realizar();
        }
        else{
            this.cadastrar(g);
        }
    }

    private void cadastrar(Gesto g){
        Debug.Log("Nao definido, deseja cadastrar uma nova acao para essa sequencia de gestos? (Y/N)");
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Escreva a acao e aperte enter ao terminar");
            while (!Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                acao.capturar();
            }
            Gesto salvarG = new Gesto();
            salvarG.set_gesto(g);
            Acao salvarA = new Acao();
            salvarA.set_acao(acao);

            dicionario.Add(salvarG, salvarA);
            acao.Clear();
            Debug.Log("Pronto");
        }
        else
        {
            Debug.Log("Entao... falou");
        }
    }
 
}
