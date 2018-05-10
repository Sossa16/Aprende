using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReporteTexto : MonoBehaviour {

	public Text txtReporte;
	double numeroPreguntas = ControladorTexto.preguntasCorrectas;




	// Use this for initialization
	void Start () {
		double preguntasDoble = numeroPreguntas;
		double porcentajePreguntasCorrectas = (numeroPreguntas * 0.05) * 100;
		string nombreM= PlayerPrefs.GetString ("nombre");
		txtReporte.text = nombreM + ", su desempeño en la prueba fue de:\n" + porcentajePreguntasCorrectas + "%"  ;
		
	}
		
}
