using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Dicionario d = new Dicionario();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
		{
			print(gameObject);
			GetComponent<ParticleSystem>();
		//	print(GetComponent<ParticleSystem>());
			/*if(gameObject.GetComponent<ParticleSystem>().isPlaying)
			{
				gameObject.GetComponent<ParticleSystem>().Play();
				gameObject.GetComponent<ParticleSystem>().Stop();
			}else{
				gameObject.GetComponent<ParticleSystem>().Play();
			}*/
		}
	}
}
