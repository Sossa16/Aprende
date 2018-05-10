using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta4 : MonoBehaviour {

	static string r1 = "Un texto de historia antropológica precolombina.";
	static string r2 = "La congelación de ciertas zonas del planeta porque allí se\ndesplazaron las placas y el magma bajo ellas.";
	static string r3 = "Porque se enfrentan dos cargas eléctricas opuestas.";
	static string r4 = "Se acumula en el fondo de la piscina.";
	static string r5 = "Tierra";
	static string r6 = "Los humanos";
	static string r7 = "Sismo";
	static string r8 = "Es una escultura antigua";
	static string r9 = "Es la transformación progresiva de las\n especies para poder sobrevivir.";
	static string r10 = "Por seis células.";

	static string r11 = "-3";
	static string r12 = "7";
	static string r13 = "Miércoles";
	static string r14 = "4";
	static string r15 = "75";

	static string r16 = "Césped, ínfimo, trauma";
	static string r17 = "El Juez dictó una sentencia justa.";
	static string r18 = "Fénix, fórceps, azúcar";
	static string r19 = "Submarino";
	static string r20 = "hiponimia";

	List<string> respuestasD = new List<string>(){r1, r2, r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16,r17,r18,r19,r20};

	
	// Update is called once per frame
	public void Update () {
		if (ControladorTexto.preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = "D. " + respuestasD [ControladorTexto.preguntaRandom];	

		}
	}

	public void OnMouseDown(){
		ControladorTexto.RespuestaSeleccionada = gameObject.name;
		//Debug.Log (gameObject.name);
		ControladorTexto.Seleccionada= "y";
		ControladorTexto.preguntaRandom = -1;
	}
}
