using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta2 : MonoBehaviour {
	//Respuestas ciencias Naturales
	static string r1=  "Un diccionario de indigenismos latinoamericanos.";
	static string r2=  "La concentración de los volcanes en zonas específicas del planeta\npor el choque entre dos o varias placas tectónicas.";
	static string r3 = "Porque se enfrentan dos polos magnéticos opuestos.";
	static string r4 = "Se pierde al mezclarse con el agua. ";
	static string r5 = "Fauna";
	static string r6 = "Emision de gases hacia la atmósfera";
	static string r7 = "Tsunami";
	static string r8 = "Es un desperdicio organico.";
	static string r9 = "Es una adaptacion al clima del planeta";
	static string r10 ="Por dos células.";


	//Respuestas Matematicas
	static string r11 = "2";
	static string r12 = "-5";
	static string r13 = "Sábado";
	static string r14 = "-7";
	static string r15 = "-75";

	//Respuestas Lenguaje
	static string r16 = "Resumen, acuático, ideal";
	static string r17 = "Fue un héroe de la batalla de Ayacucho.";
	static string r18 = "Táhur, abdomen, aéreo";
	static string r19 = "Agridulce";
	static string r20 = "sinonimia";

	//Respuestas ciencias naturales parte 2
	static string r21 ="Membrana nuclear, citoplasma y núcleo";
	static string r22 ="órganos";
	static string r23 ="degustar, masticar y saborear";
	static string r24 ="Boca";
	static string r25 ="Ribosomas";
	static string r26 ="Efectuar síntesis de alimentos";
	static string r27 ="extensiva";
	static string r28 ="La explotación de biocombustibles";
	static string r29 ="Esporas";
	static string r30 ="Semilla";

	//Respuestas de lenguaje parte 2
	static string r31 ="oraciones";
	static string r32 ="ordenada";
	static string r33 ="Un individuo que habla";
	static string r34 ="verbo";
	static string r35 ="es";
	static string r36 ="trabajas";
	static string r37 ="as / soy ";
	static string r38 ="he ido";
	static string r39 ="estamos";
	static string r40 ="De final";
	static string r41 ="tuvo";
	static string r42 ="compro/he estudiado";
	static string r43 ="vas";
	static string r44 ="viene";
	static string r45 ="volverías";

	//Respuestas de matematicas parte 2
	static string r46 ="45";
	static string r47 ="Número";
	static string r48 ="Agudo";
	static string r49 ="Razón";
	static string r50 ="Complementarios";

	//Respuestas de ciencias sociales 
	static string r51 ="educación, salud y vivienda";
	static string r52 ="A las personas";
	static string r53 ="4 regiones naturales";
	static string r54 ="Clavel";
	static string r55 ="la Cordillera Central";

	List<string> respuestasB = new List<string>(){r1, r2, r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50,r51,r52,r53,r54,r55};


	
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
