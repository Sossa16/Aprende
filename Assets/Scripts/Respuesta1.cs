﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta1 : MonoBehaviour {
	//Respuestas Ciencias Naturales
	static string r1= "Una revista de tradiciones populares orientales.";
	static string r2= "La unión actual de los continentes Europa, Asia y Australia\npara formar un gran continente.";
	static string r3 = "Porque se enfrentan dos polos magnéticos iguales";
	static string r4 = "Se distribuye homogéneamente en el agua. ";
	static string r5 = "Flora";
	static string r6 = "La naturaleza";
	static string r7 = "Invierno";
	static string r8 = "Es un resto de un ser vivo que se ha petrificado a través\nde los años.";
	static string r9 = "Al paso del tiempo en la civilización";
	static string r10 ="Por una célula.";

	//Respuestas Matematicas
	static string r11 = "-2";
	static string r12 = "-11";
	static string r13 = "Viernes";
	static string r14 = "-12";
	static string r15 = "-45";

	//Respuestas Lenguaje
	static string r16 = "Bíceps, línea, guion";
	static string r17 = "Mañana visitaremos la Santa sede";
	static string r18 = "Robóts, influído, rehúso";
	static string r19 = "Blanquiazul";
	static string r20 = "antonimia";

	//Respuestas ciencias naturales parte 2
	static string r21 ="Membrana celular, citoplasma y núcleo";
	static string r22 ="Sistemas";
	static string r23 ="Ingestión, digestión, absorciòn";
	static string r24 ="Faringe";
	static string r25 ="Lisosomas";
	static string r26 ="Dirigir las actividades de la célula";
	static string r27 ="general";
	static string r28 ="La explotación agrícola";
	static string r29 ="Polen";
	static string r30 ="Feto";


	List<string> respuestasA = new List<string>(){r1, r2, r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30};

	
	// Update is called once per frame
	 public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "A. " + respuestasA [ControladorTexto.preguntaRandom];	

		}
	}

	 public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
	}
}
