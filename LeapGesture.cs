using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapGesture {
    List<Posicao> gestoLeap;
    private Posicao captura;

	public LeapGesture () {
        gestoLeap = new List<Posicao>();
        captura = new Posicao();
    }
    public List<Posicao> get_gesto() {
        return gestoLeap;
    }

    public void capturarLeap(){
        if (!Input.GetKeyDown(KeyCode.Return)){
            captura.capturar();
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            if (is_empty()) { 
                this.Add(captura);
            }
            else if (!get_last().compara(captura) && !captura.empty()){
                this.Add(captura);
            }
            captura.Clear();
        }
    }
    public bool is_finalizated(){
        int tamanho = gestoLeap.Count;
        if(tamanho == 1){
            return false;
        }
        return gestoLeap[tamanho].ended();
    }
    public bool is_rename() {
        int tamanho = gestoLeap.Count;
        if (tamanho == 0)
        {
            return false;
        }
        return gestoLeap[tamanho].rename();
    }
    public bool is_empty() {
        return gestoLeap.Count == 1;
    }


    private Posicao get_last(){

        return gestoLeap[gestoLeap.Count - 1];
    }
    private void Add(Posicao p) {
        gestoLeap.Add(new Posicao());
        this.get_last().set_posicao(p);
    }
}
