using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTexto : MonoBehaviour {

	List<string> preguntas = new List<string>(){"primera pregunta", "segunda pregunta", "tercera pregunta", "cuarta pregunta"};
	List<string> respuestas = new List<string>(){"Respuesta1", "Respuesta3", "Respuesta2", "Respuesta4"};

	public static int preguntaRandom = -1;
	public static string RespuestaSeleccionada;
	public static string Seleccionada = "n";



	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = preguntas [0];

	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (preguntaRandom == -1) {
			preguntaRandom = Random.Range (0, 4);
		}
		if (preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = preguntas [preguntaRandom];
		}

		if (Seleccionada == "y") {
			Seleccionada = "n";
			/*Debug.Log (respuestas [preguntaRandom]);*/
			if (respuestas [preguntaRandom] == RespuestaSeleccionada) {
				Debug.Log ("correcto" + " " + preguntaRandom);
			}
		}


	}
}
