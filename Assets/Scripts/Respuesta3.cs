using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta3 : MonoBehaviour {
	//Respuestas Ciencias Naturales
	static string r1 = "Una antología de poesía autóctona de los mayas.";
	static string r2 = "La concentración de las montañas en un solo lugar del planeta\n por el choque entre las dos únicas placas tectónicas existentes.";
	static string r3 = "Porque se enfrentan dos cargas eléctricas iguales.";
	static string r4 = "Se evapora dentro de la piscina.";
	static string r5 = "Agua";
	static string r6 = "El adelgazamiento de la capa de ozono";
	static string r7 = "Efecto invernadero";
	static string r8 = "Es un ser vivo";
	static string r9 = "Es el cambio de una persona";
	static string r10 ="Por tres células.";


	//Respuestas Matematicas
	static string r11 = "-5";
	static string r12 = "5";
	static string r13 = "Lunes";
	static string r14 = "-2";
	static string r15 = "15";

	//Respuestas Lenguaje
	static string r16 = "Traen, Clausto, Lápiz";
	static string r17 = "El lobo engañó a Caperucita roja.";
	static string r18 = "Mástil, traúma, reláx";
	static string r19 = "Tocadiscos";
	static string r20 = "hiperonimia";

	//Respuestas ciencias naturales parte 2
	static string r21 ="Núcleo, jugo nuclear y cromosomas.";
	static string r22 ="Tejidos";
	static string r23 ="Pensar, reír y comer";
	static string r24 ="Tràquea";
	static string r25 ="Vacuolas";
	static string r26 ="Transmitir la información genética";
	static string r27 ="intensiva";
	static string r28 ="El uso de combustibles fósiles";
	static string r29 ="Semillas";
	static string r30 ="Espora";

	//Respuestas de lenguaje parte 2
	static string r31 ="expresiones";
	static string r32 ="nítida";
	static string r33 ="Las palabras agudas";
	static string r34 ="final";
	static string r35 ="dice";
	static string r36 ="te dedicas";
	static string r37 ="tienes / tengo";
	static string r38 ="había ido";
	static string r39 ="iremos";
	static string r40 ="En fin";
	static string r41 ="tenía";
	static string r42 ="compraré/estudiaré";
	static string r43 ="ve";
	static string r44 ="venga";
	static string r45 ="vuelvas";

	//Respuestas de matematicas parte 2
	static string r46 ="50";
	static string r47 ="Medios";
	static string r48 ="Correspondientes";
	static string r49 ="Fracción";
	static string r50 ="Imaginarios";

	//Respuestas de ciencias sociales 
	static string r51 ="Ropa, salud y vivienda";
	static string r52 ="A los extranjeros";
	static string r53 ="7 regiones naturales";
	static string r54 ="Hortensia";
	static string r55 ="la Cordillera Oriental";

	List<string> respuestasC = new List<string>(){r1, r2, r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50,r51,r52,r53,r54,r55};

	
	// Update is called once per frame
	public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "C. " + respuestasC [ControladorTexto.preguntaRandom];	
		}
		
	}

	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
	
	}


}
