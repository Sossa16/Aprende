using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReporteTexto : MonoBehaviour {

	public Text txtReporte;
	int numeroPreguntas = ControladorTexto.preguntasCorrectas;


	// Use this for initialization
	void Start () {
		string nombreM= PlayerPrefs.GetString ("nombre");
		txtReporte.text = nombreM + ", su desempeño en la prueba fue:\n" + numeroPreguntas + " preguntas acertas."  ;
		
	}
		
}
