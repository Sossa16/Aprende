using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorTexto : MonoBehaviour {

	List<string> preguntas = new List<string>(){"primera pregunta", "segunda pregunta", "tercera pregunta", "cuarta pregunta"};
	List<string> respuestas = new List<string>(){"Respuesta1", "Respuesta3", "Respuesta2", "Respuesta4"};
	List<int> preguntaAnterior = new List<int>(){-1,-1,-1,-1};
	public int numeroPregunta = 0;

	public static int preguntaRandom = -1;
	public static string RespuestaSeleccionada;
	public static string Seleccionada = "n";
	public static int preguntasCorrectas = 0;
	public int totalPreguntas = 0;

	public void Update ()
	{
		if (totalPreguntas == 3) {
			Reporte.OnMouseDown ();

		} else {
		if (preguntaRandom == -1) {
			preguntaRandom = Random.Range (0, 3);

			for (int i = 0; i < 2; i++) {
					
				if (preguntaRandom != preguntaAnterior [i]) {
					print ("soy diferente");

				} else {
					preguntaRandom = -1;
				}

			}

			if (preguntaRandom > -1) {
				GetComponent<TextMesh> ().text = preguntas [preguntaRandom];
				preguntaAnterior [numeroPregunta] = preguntaRandom;
			}

			if (Seleccionada == "y") {
					
				totalPreguntas += 1;
				numeroPregunta += 1;
				Seleccionada = "n";

				if (respuestas [preguntaRandom] == RespuestaSeleccionada) {
					Debug.Log ("correcto" + " " + preguntaRandom);
					preguntasCorrectas += 1;
	
					} 
				}
			}
		}
	}
}
