using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorTexto : MonoBehaviour {
	
	/*Ciencias Naturales
	 *Ciencias Sociales
	 *Lenguaje
	 *Matematicas
	 */

	//Ciencias naturales
	static string pr1 = "Debes preparar una exposición sobre la importancia del\nmito en la construcción de la identidad de las culturas latino-\namericanas. Para ello podrías consultar, principalmente: \n";
	static string pr2 = "¿Cuál de los siguientes accidentes geográficos es una\nexplicación del movimiento de las placas tectónicas\na lo largo de la historia de la Tierra?";
	static string pr3 = "Juan observa que cuando acerca dos imanes estos pueden\n atraerse o repelerse. ¿Por qué se pueden atraer dos imanes?";
	static string pr4 = "La piscina donde nadan se limpia con “cloro”. La adición del cloro al\nagua produce una solución porque el cloro:";
	static string pr5 = "Uno de los principales recursos naturales renovables, está\n formado básicamente por  animales y se le conoce como:";
	static string pr6 = "La lluvia ácida es consecuencia de:";
	static string pr7 = "El fenómeno que ocasiona el calentamiento del planeta\n cambios climáticos y múltiples enfermedades respiratorios\n se le llama:";
	static string pr8 = "¿Qué es un fósil?";
	static string pr9 = "¿A qué llamamos evolución?";
	static string pr10 ="¿Cómo están formados los seres unicelulares?";
	//Matematicas
	static string pr11 = "Si al entero (-1) le restamos el\n  entero(-3), resulta:)";
	static string pr12 = "Si n=2 y m=-3, ¿Cual es el valor -nm - (n+m)?";
	static string pr13 = "Si hoy es miércoles, ¿Que día de\n la semana será en 100 días más,\n a partir de hoy?";
	static string pr14 = "Si 16(n + 8) = 16, entonces\n n - 5 es igual a:";
	static string pr15 = "si x=-3, entonces(x - 2)(2χ² -3) =";
	//Lenguaje
	static string pr16 = "Señale la alternativa que contiene solo palabras\n graves.";
	static string pr17 = "Elija la alternativa que denota empleo adecuado de las letras mayúsculas.";
	static string pr18 = "Seleccione la serie que presenta correcta tildación de palabras";
	static string pr19 = "Indique la alternativa en la que hay una palabra derivada";
	static string pr20 = "La palabra flor, respecto a la palabra geranio, está en relación semántica de:";

	List<string> preguntas = new List<string>(){pr1, pr2, pr3, pr4, pr5,pr6,pr7,pr8,pr9,pr10,pr11,pr12,pr13,pr14,pr15,pr16,pr17,pr18,pr19,pr20};
	List<string> respuestas = new List<string>(){"Respuesta1", "Respuesta2", "Respuesta2", "Respuesta4",
		"Respuesta2","Respuesta2","Respuesta3","Respuesta1","Respuesta4","Respuesta1","Respuesta2","Respuesta4","Respuesta1","Respuesta1",
		"Respuesta2","Respuesta3","Respuesta2","Respuesta4","Respuesta4","Respuesta3"};
	//List<int> preguntaAnterior = new List<int>(){-1,-1,-1,-1};
	public int numeroPregunta = 0;

	public static int preguntaRandom = -1;
	public static string RespuestaSeleccionada;
	public static string Seleccionada = "n";
	public static int preguntasCorrectas = 0;
	public int totalPreguntas = 0;


	public void Update ()
	{
<<<<<<< HEAD

=======
		
>>>>>>> 18004a55ff0da5422e95192faf563093388e315a
		if (preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = preguntas [preguntaRandom];

		} 

		if (preguntaRandom == -1) {
			preguntaRandom = Random.Range (0, 20);
			print(preguntaRandom + "if");

		}
<<<<<<< HEAD
			
=======



		//			for (int i = 1; i <= preguntas.Count - 1; i++) {
		//				if (preguntaRandom != preguntaAnterior [i]) {
		//					print ("soy diferente");
		//				} else {
		//					preguntaRandom = -1;
		//				}
		//			}



>>>>>>> 18004a55ff0da5422e95192faf563093388e315a
		if (Seleccionada == "y") {
			//numeroPregunta += 1;
			Seleccionada = "n";

			print (respuestas [preguntaRandom]+ " " +RespuestaSeleccionada);
			if (respuestas [preguntaRandom] == RespuestaSeleccionada) {

				totalPreguntas = totalPreguntas + 1;
				preguntasCorrectas = preguntasCorrectas + 1;
				print ("si");
				if (totalPreguntas==20) {
					Reporte.OnMouseDown ();
				} else {
					CambioPregunta.OnMouseDown ();
				}

			} else {

				totalPreguntas = totalPreguntas +1;
<<<<<<< HEAD
				if(totalPreguntas!=20){
=======
				if(totalPreguntas!=3){
>>>>>>> 18004a55ff0da5422e95192faf563093388e315a
					CambioPregunta.OnMouseDown ();
				}else{
					Reporte.OnMouseDown ();
				}
			}

		}
	}
}

