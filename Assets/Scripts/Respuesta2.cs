using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta2 : MonoBehaviour {
	
	List<string> rp2 = new List<string>(){"e", "f","g","h"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = rp2 [ControladorTexto.preguntaRandom];	
		}
	}


	void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
	}
}
