using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acao {

    string acao;

    public Acao(){
        acao = "";
    }
    public void set_acao(Acao a) { 
         acao = a.get_acao();
    }
    public string get_acao(){
        return acao;
    }
    public void realizar(){
        Debug.Log(string.Concat("acao acionada! - " , this.acao));
    }
    public bool compara(Acao p){
        return this.get_acao() == p.get_acao();
    }
    public void capturar() {
   
           this.set_acao(string.Concat(acao, Input.inputString));
    }
    public void Clear(){
        acao = "";
    }
    private string concat(string a){
        return string.Concat(acao, a);
    }
    private void set_acao(string a){
        acao = a;
    }
}
