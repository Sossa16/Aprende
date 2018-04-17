using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta3 : MonoBehaviour {
	
	List<string> rp3 = new List<string>(){"i", "j","k","l"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = rp3 [ControladorTexto.preguntaRandom];	
		}
		
	}

	void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
	}


}
