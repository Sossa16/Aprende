using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta3 : MonoBehaviour {
	
	List<string> rp3 = new List<string>(){"i", "j","k","l"};

	
	// Update is called once per frame
	public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = rp3 [ControladorTexto.preguntaRandom];	
		}
		
	}

	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
		ControladorTexto.preguntaRandom = -1;
	}


}
