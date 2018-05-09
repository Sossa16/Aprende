using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorTexto : MonoBehaviour {

	static string pr1 = "Debes preparar una exposición sobre la importancia del\nmito en la construcción de la identidad de las culturas latino-\namericanas. Para ello podrías consultar, principalmente: \n";
	static string pr2 = "¿Cuál de los siguientes accidentes geográficos es una\nexplicación del movimiento de las placas tectónicas\na lo largo de la historia de la Tierra?";
	static string pr3 = "Juan observa que cuando acerca dos imanes estos pueden\n atraerse o repelerse. ¿Por qué se pueden atraer dos imanes?";
	static string pr4 = "La piscina donde nadan se limpia con “cloro”. La adición del cloro al\nagua produce una solución porque el cloro:";


	List<string> preguntas = new List<string>(){pr1, pr2, pr3, pr4};
	List<string> respuestas = new List<string>(){"Respuesta1", "Respuesta2", "Respuesta2", "Respuesta4"};
	//List<int> preguntaAnterior = new List<int>(){-1,-1,-1,-1};
	public int numeroPregunta = 0;

	public static int preguntaRandom = -1;
	public static string RespuestaSeleccionada;
	public static string Seleccionada = "n";
	public static int preguntasCorrectas = 0;
	public int totalPreguntas = 0;


	public void Update ()
	{
		
		if (preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = preguntas [preguntaRandom];
					
		} 

		if (preguntaRandom == -1) {
			preguntaRandom = Random.Range (0, 4);
			print(preguntaRandom + "if");

		}




		if (Seleccionada == "y") {
			//numeroPregunta += 1;
			Seleccionada = "n";

			print (respuestas [preguntaRandom]+ " " +RespuestaSeleccionada);
			if (respuestas [preguntaRandom] == RespuestaSeleccionada) {
				
				totalPreguntas = totalPreguntas + 1;
				preguntasCorrectas = preguntasCorrectas + 1;
				print ("si");
				if (totalPreguntas==3) {
					Reporte.OnMouseDown ();
				} else {
					CambioPregunta.OnMouseDown ();
				}

			} else {
				totalPreguntas = totalPreguntas +1;
				if(totalPreguntas!=3){
					CambioPregunta.OnMouseDown ();
				}else{
					Reporte.OnMouseDown ();
				}
			}

		}
	}
}

