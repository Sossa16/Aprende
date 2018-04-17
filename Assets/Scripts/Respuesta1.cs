using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta1 : MonoBehaviour {

	List<string> rp1 = new List<string>(){"a", "b","c","d"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = rp1 [ControladorTexto.preguntaRandom];	

		}
	}

	void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";

	}
}
