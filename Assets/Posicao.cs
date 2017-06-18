using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicao{
    string posicao;

    public Posicao(){
        posicao = "";
    }
    public void set_posicao(Posicao p){
        posicao = p.get_posicao();
    }
    public string get_posicao() {
        return posicao;
    }
    public bool compara(Posicao p) {
        return this.get_posicao() == p.get_posicao();
    }
    public void capturar(){
        if (!(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftShift))){       
                this.set_posicao( string.Concat(posicao, Input.inputString) );
        }
    }
    public bool ended(){
        return this.get_posicao() == "e";
    }
    public bool rename()
    {
        return this.get_posicao() == "r";
    }
    public bool empty(){
        return posicao == "";
    }
    public void Clear(){
        posicao = "";
    }

    private string concat(string p)
    {
        return string.Concat(posicao, p);
    }
    private void set_posicao(string p){
        posicao = p;
    }

}
