using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPregunta : MonoBehaviour {

	public void Cambio()
	{
		if (ControladorTexto.Seleccionada == "y") {
			//numeroPregunta += 1;
			ControladorTexto.Seleccionada = "n";

			print (ControladorTexto.respuestas [ControladorTexto.preguntaRandom]+ " " + ControladorTexto.RespuestaSeleccionada);
			if (ControladorTexto.respuestas [ControladorTexto.preguntaRandom] == ControladorTexto.RespuestaSeleccionada) {

				ControladorTexto.totalPreguntas = ControladorTexto.totalPreguntas + 1;
				ControladorTexto.preguntasCorrectas = ControladorTexto.preguntasCorrectas + 1;
				print ("si");
				if (ControladorTexto.totalPreguntas==3) {
					Reporte.OnMouseDown ();
				}

			} else {

				ControladorTexto.totalPreguntas = ControladorTexto.totalPreguntas +1;

				if(ControladorTexto.totalPreguntas ==3){
					Reporte.OnMouseDown ();
				}
			}

		}
		ControladorTexto.preguntaRandom = -1;

	}
}
