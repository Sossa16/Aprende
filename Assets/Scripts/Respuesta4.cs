using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta4 : MonoBehaviour {

	static string r1 = "Un texto de historia antropológica precolombina.";
	static string r2 = "La congelación de ciertas zonas del planeta porque allí se\ndesplazaron las placas y el magma bajo ellas.";
	static string r3 = "Porque se enfrentan dos cargas eléctricas opuestas.";
	static string r4 = "Se acumula en el fondo de la piscina.";

	List<string> respuestasD = new List<string>(){r1, r2,r3,r4};

	
	// Update is called once per frame
	public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "D. " + respuestasD [ControladorTexto.preguntaRandom];	

		}
	}

	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		//Debug.Log (gameObject.name);
		ControladorTexto.Seleccionada= "y";
		ControladorTexto.preguntaRandom = -1;
	}
}
