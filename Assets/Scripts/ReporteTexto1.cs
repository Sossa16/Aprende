using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReporteTexto1 : MonoBehaviour {

	public Text txtReporte;
	
	int totalPreguntasPorArea;
	int totalPreguntas;

	double porcentajeM;
	double porcentajeC;
	double porcentajeL;
	double porcentajeS;

	double porcentajeTotal;
	
	public void Start(){

		int correctasM = PlayerPrefs.GetInt ("contadorMatematicasCorrectas11");
		int incorrectasM = PlayerPrefs.GetInt ("contadorMatematicasIncorrectas11");
		int correctasC = PlayerPrefs.GetInt ("contadorCienciasCorrectas11");
		int incorrectasC = PlayerPrefs.GetInt ("contadorCienciasIncorrectas11");
		int correctasL = PlayerPrefs.GetInt ("contadorLenguajeCorrectas11");
		int incorrectasL = PlayerPrefs.GetInt ("contadorLenguajeIncorrectas11");
		int correctasS = PlayerPrefs.GetInt ("contadorSocialesCorrectas11");
		int incorrectasS = PlayerPrefs.GetInt ("contadorSocialesIncorrectas11");

		int totalPreguntasCorrectas= correctasM + correctasC + correctasL + correctasS;
		int totalPreguntasIncorrectas = incorrectasC + incorrectasM + incorrectasL + incorrectasS;

		totalPreguntas = 8;
		totalPreguntasPorArea = 2;
	
		porcentajeTotal = (totalPreguntasCorrectas * 100)/totalPreguntas;
		porcentajeM = (correctasM * 100)/totalPreguntasPorArea;
		porcentajeC = (correctasC * 100)/totalPreguntasPorArea;
		porcentajeL = (correctasL * 100)/totalPreguntasPorArea;
		porcentajeS = (correctasS* 100)/totalPreguntasPorArea;

	
		string nombreM= PlayerPrefs.GetString ("nombreEstudiante");

		txtReporte.text = nombreM + ", su desempeño en la prueba fue de: " + porcentajeTotal + "%" + "\n" +
									"Obteniendo un total de " + totalPreguntasCorrectas + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + totalPreguntasIncorrectas + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Matemáticas su desempeño fue de: " + porcentajeM + "%" + "\n" +
									"Obteniendo un total de " + correctasM + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasM + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Ciencias su desempeño fue de: " + porcentajeC + "%" + "\n" +
									"Obteniendo un total de " + correctasC + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasC + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Lenguaje su desempeño fue de: " + porcentajeL + "%" + "\n" +
									"Obteniendo un total de " + correctasL + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasL + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Sociales su desempeño fue de: " + porcentajeS + "%" + "\n" +
									"Obteniendo un total de " + correctasS + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasS + " preguntas contestadas incorrectamente" + "\n" + "\n";
		
		
	}
}