using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReporteTexto : MonoBehaviour {

	public Text txtReporte;
	
	int totalPreguntas;

	double porcentaje;
	
	public void Start(){
		int contador = PlayerPrefs.GetInt ("contador");
		totalPreguntas = 4;
	
		
		porcentaje = (contador * 100)/totalPreguntas;
		string nombreM= PlayerPrefs.GetString ("nombreEstudiante");
		txtReporte.text = nombreM + ", su desempeño en la prueba fue de:\n" + porcentaje + "%"  ;
		//Debug.Log("Esto esta llegando al metodo" + correcta);
		
	}
}