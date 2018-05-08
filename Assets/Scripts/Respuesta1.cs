using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta1 : MonoBehaviour {
	static string r1= "Una revista de tradiciones populares orientales.";
	static string r2= "La unión actual de los continentes Europa, Asia y Australia\npara formar un gran continente.";
	static string r3 = "Porque se enfrentan dos polos magnéticos iguales";
	static string r4 = "Se distribuye homogéneamente en el agua. ";

	List<string> respuestasA = new List<string>(){r1, r2, r3,r4};

	
	// Update is called once per frame
	 public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "A. " + respuestasA [ControladorTexto.preguntaRandom];	

		}
	}

	 public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		//Debug.Log (gameObject.name);
		ControladorTexto.Seleccionada= "y";
		//ControladorTexto.preguntaRandom = -1;
	}
}
