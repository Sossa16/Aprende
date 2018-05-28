using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta4 : MonoBehaviour {
	//Respuestas ciencias Naturales
	static string r1 = "Un texto de historia antropológica precolombina.";
	static string r2 = "La congelación de ciertas zonas del planeta porque allí se\ndesplazaron las placas y el magma bajo ellas.";
	static string r3 = "Porque se enfrentan dos cargas eléctricas opuestas.";
	static string r4 = "Se acumula en el fondo de la piscina.";
	static string r5 = "Tierra";
	static string r6 = "Los humanos";
	static string r7 = "Sismo";
	static string r8 = "Es una escultura antigua";
	static string r9 = "Es la transformación progresiva de las\n especies para poder sobrevivir.";
	static string r10 ="Por seis células.";


	//Respuestas Matematicas
	static string r11 = "-3";
	static string r12 = "7";
	static string r13 = "Miércoles";
	static string r14 = "4";
	static string r15 = "75";

	//Respuestas Lenguaje
	static string r16 = "Césped, ínfimo, trauma";
	static string r17 = "El Juez dictó una sentencia justa.";
	static string r18 = "Fénix, fórceps, azúcar";
	static string r19 = "Submarino";
	static string r20 = "hiponimia";

	//Respuestas ciencias naturales parte 2
	static string r21 ="Citoplasma, mitocondria y núcleo";
	static string r22 ="Meristemas";
	static string r23 ="Masticación, digerir y saborear";
	static string r24 ="Laringe";
	static string r25 ="Mitocondrias";
	static string r26 ="Efectuar síntesis de ARN y ADN";
	static string r27 ="cualitativa";
	static string r28 ="La industrialización mundial";
	static string r29 ="A y B";
	static string r30 ="Ninguna de las anteriores";

	//Respuestas de lenguaje parte 2
	static string r31 ="Partes de la oración";
	static string r32 ="desordenada";
	static string r33 ="Expresiones escritas";
	static string r34 ="historia";
	static string r35 ="vive";
	static string r36 ="haces";
	static string r37 ="tener / teno";
	static string r38 ="iba";
	static string r39 ="seremos";
	static string r40 ="A final";
	static string r41 ="ha tenido";
	static string r42 ="compraré/estudio";
	static string r43 ="es";
	static string r44 ="vendría";
	static string r45 ="volverás";

	//Respuestas de matematicas parte 2
	static string r46 ="60";
	static string r47 ="Concreto";
	static string r48 ="Suplementarios";
	static string r49 ="Equiláteros";
	static string r50 ="Rectángulos";

	//Respuestas de ciencias sociales 
	static string r51 ="educación, salud y alimentos";
	static string r52 ="Al perro";
	static string r53 ="6 regiones naturales";
	static string r54 ="Heliconia";
	static string r55 ="la Cordillera del sur";

	List<string> respuestasD = new List<string>(){r1, r2, r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,r31,r32,r33,r34,r35,r36,r37,r38,r39,r40,r41,r42,r43,r44,r45,r46,r47,r48,r49,r50,r51,r52,r53,r54,r55};

	
	// Update is called once per frame
	public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "D. " + respuestasD [ControladorTexto.preguntaRandom];	

		}
	}

	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		ControladorTexto.Seleccionada= "y";
	
	}
}
