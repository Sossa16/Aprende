using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta4 : MonoBehaviour {
	
	List<string> rp4 = new List<string>(){"m", "n","o","p"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = rp4 [ControladorTexto.preguntaRandom];	

		}
	}

	void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
	}
}
