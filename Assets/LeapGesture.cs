using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapGesture {
    List<LeapHand_B> gestoLeap;
    int size;
	public LeapGesture () {
        gestoLeap = new List<LeapHand_B>();
        gestoLeap.Add(new LeapHand_B());
        size = 0;
    }
    public List<LeapHand_B> get_gesto() {
        return gestoLeap;
    }

    public void capturarLeap()
    {
        if (!Input.GetKeyDown(KeyCode.Return))
        {
            gestoLeap[size].posicao = string.Concat(gestoLeap[size].posicao);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!is_ended())
            {
                size++;
                gestoLeap.Add(new LeapHand_B());
            }
        }
    }
    public bool is_ended(){
        if(size == 0){
            return false;
        }
        return gestoLeap[size].posicao=="e";
    }

    public bool is_empty() {
        return gestoLeap.Count == 0;
    }
    public void clear()
    {
        gestoLeap.Clear();
        gestoLeap.Add(new LeapHand_B());
        size = 0;
    }
}
