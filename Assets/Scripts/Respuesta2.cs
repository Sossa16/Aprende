using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta2 : MonoBehaviour {

	static string r1=  "Un diccionario de indigenismos latinoamericanos.";
	static string r2=  "La concentración de los volcanes en zonas específicas del planeta\npor el choque entre dos o varias placas tectónicas.";
	static string r3 = "Porque se enfrentan dos polos magnéticos opuestos.";
	static string r4 = "Se pierde al mezclarse con el agua. ";
	static string r5 = "Fauna";
	static string r6 = "Emision de gases hacia la atmósfera";
	static string r7 = "Tsunami";
	static string r8 = "Es un desperdicio organico.";
	static string r9 = "Es una adaptacion al clima del planeta";
	static string r10 = "Por dos células.";

	static string r11 = "2";
	static string r12 = "-5";
	static string r13 = "Sábado";
	static string r14 = "-7";
	static string r15 = "-75";

	static string r16 = "Resumen, acuático, ideal";
	static string r17 = "Fue un héroe de la batalla de Ayacucho.";
	static string r18 = "Táhur, abdomen, aéreo";
	static string r19 = "Agridulce";
	static string r20 = "sinonimia";


	List<string> respuestasB = new List<string>(){r1, r2, r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20};


	
	// Update is called once per frame
	 public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "B. " + respuestasB [ControladorTexto.preguntaRandom];	
		}
	}


	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada = "y";

	}
}
