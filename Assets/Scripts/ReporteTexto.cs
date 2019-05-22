using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReporteTexto : MonoBehaviour {

	ManejoJuego manejoJuego = new ManejoJuego();
	public Text txtReporte;
	int correcta;

	public SeleccionarRespuesta seleccionarRespuesta = null;

	int totalPreguntas;

	double porcentaje;

	
	public void Start(){
		correcta = 4;
		/* totalPreguntas = 4;
	
		
		porcentaje = (correcta * 1)/totalPreguntas;*/
		string nombreM= PlayerPrefs.GetString ("nombre");
		txtReporte.text = nombreM + ", su desempeño en la prueba fue de:\n" + correcta + "%"  ;
		//Debug.Log("Esto esta llegando al metodo" + correcta);
		
	}
}