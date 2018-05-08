using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta2 : MonoBehaviour {

	static string r1=  "Un diccionario de indigenismos latinoamericanos.";
	static string r2=  "La concentración de los volcanes en zonas específicas del planeta\npor el choque entre dos o varias placas tectónicas.";
	static string r3 = "Porque se enfrentan dos polos magnéticos opuestos.";
	static string r4 = "Se pierde al mezclarse con el agua. ";

	List<string> respuestasB = new List<string>(){r1, r2, r3,r4};


	
	// Update is called once per frame
	 public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "B. " + respuestasB [ControladorTexto.preguntaRandom];	
		}
	}


	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada = "y";
		ControladorTexto.preguntaRandom = -1;
	}
}
