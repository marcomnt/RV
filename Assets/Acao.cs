using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

public class Acao {

    string acao;

    public Acao(){
        acao = "";
    }

    public void realizar(){
        Debug.Log(string.Concat("acao acionada! - " , this.acao));
    }
    public void capturar() {
  
    }
    public void clear(){
        acao = "";
    }
    private string concat(string a){
        return string.Concat(acao, a);
    }
}
