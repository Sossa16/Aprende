using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta3 : MonoBehaviour {

	static string r1 = "Una antología de poesía autóctona de los mayas.";
	static string r2 = "La concentración de las montañas en un solo lugar del planeta\n por el choque entre las dos únicas placas tectónicas existentes.";
	static string r3 = "Porque se enfrentan dos cargas eléctricas iguales.";
	static string r4 = "Se evapora dentro de la piscina.";

	List<string> respuestasC = new List<string>(){r1, r2, r3,r4};

	
	// Update is called once per frame
	public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "C. " + respuestasC [ControladorTexto.preguntaRandom];	
		}
		
	}

	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
		ControladorTexto.preguntaRandom = -1;
	}


}
