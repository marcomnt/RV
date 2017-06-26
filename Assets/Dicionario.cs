using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dicionario {
    Dictionary<Gesto, Acao> dicionario;

    // Use this for initialization
    public Dicionario () {
        dicionario = new Dictionary< Gesto,Acao>();
	}
    
    public void cadastrar(Gesto g,Acao a) 
    {
        dicionario.Add(g, a);
    }

    public Acao consultar(Gesto g)
    {
        Acao a;
        dicionario.TryGetValue(g, out a);
        return a;
    }
}
