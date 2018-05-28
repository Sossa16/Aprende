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
	static string pr1 = "Debes preparar una exposición sobre la importancia del\nmito en la construcción de la identidad de las culturas\nlatino-americanas. Para ello podrías consultar: \n";
	static string pr2 = "¿Cuál de los siguientes accidentes geográficos es una\nexplicación del movimiento de las placas tectónicas\na lo largo de la historia de la Tierra?";
	static string pr3 = "Juan observa que cuando acerca dos imanes pueden\natraerse o repelerse. ¿Por qué se pueden atraer\ndos imanes?";
	static string pr4 = "La piscina donde nadan se limpia con “cloro”.La adición\ndel cloro al agua produce una solución porque el cloro:";
	static string pr5 = "Uno de los principales recursos naturales renovables, está\nformado básicamente por  animales y se le conoce como:";
	static string pr6 = "La lluvia ácida es consecuencia de:";
	static string pr7 = "El fenómeno que ocasiona el calentamiento del planeta\ncambios climáticos y múltiples enfermedades respiratorios\nse le llama:";
	static string pr8 = "¿Qué es un fósil?";
	static string pr9 = "¿A qué llamamos evolución?";
	static string pr10 ="¿Cómo están formados los seres unicelulares?";


	//Matematicas
	static string pr11 = "Si al entero (-1) le restamos el entero(-3),\nresulta:";
	static string pr12 = "Si n=2 y m=-3, ¿Cual es el valor -nm - (n+m)?";
	static string pr13 = "Si hoy es miércoles, ¿Que día de la semana\nserá en 100 días más, a partir de hoy?";
	static string pr14 = "Si 16(n + 8) = 16, entonces n - 5 es\nigual a:";
	static string pr15 = "si x=-3, entonces (x - 2)(2χ² -3) =";
	//Lenguaje
	static string pr16 = "Señale la alternativa que contiene solo palabras\ngraves.";
	static string pr17 = "Elija la alternativa que denota empleo adecuado\nde las letras mayúsculas.";
	static string pr18 = "Seleccione la serie que presenta correcta tildación\nde palabras";
	static string pr19 = "Indique la alternativa en la que hay una palabra derivada";
	static string pr20 = "La palabra flor, respecto a la palabra geranio, está\nen relación semántica de:";

	//ciencias Naturales Parte 2
	static string pr21 ="La Célula está conformada por 3 partes\nfundamentales que son:";
	static string pr22 ="Las asociaciones de células que cumplen una\nmisma función, reciben el nombre de:\n";
	static string pr23 ="Son etapas de la nutrición";
	static string pr24 ="Órgano del sistema digestivo que permite el\npaso del bolo alimenticio al esófago";
	static string pr25 ="El siguiente organelo se le considera como\ncentral energética de la célula";
	static string pr26 ="El núcleo de la célula cumple varias funciones,\nmenos una de ellas y es:";
	static string pr27 ="La densidad es una propiedad que no depende\nde la cantidad de sustancia que se utilice,\npor lo tanto es";
	static string pr28 ="El aumento de la temperatura en nuestro\nplanetaestá asociado a:";
	static string pr29 ="¿Como se le llama al polvo que sueltan\nlas plantas con flores para reproducirse?";
	static string pr30 ="embrion de una planta";

	//Continuacion lenguaje
	static string pr31 ="sustantivo y verbo son:";
	static string pr32 ="Para que una oración tenga sentido debe estar:";
	static string pr33 ="Llamamos sujeto a:";
	static string pr34 ="En la oración se realiza siempre una acción,\nes decir que siempre lleva un:";
	static string pr35 ="Complete la oración:\nLa gente de esta ciudad _______ muy simpática.";
	static string pr36 ="Complete la oración:\nYo soy enfermera, y tú ¿a qué _________?";
	static string pr37 ="Complete la oración:\n¿Cuántos años __________ tú? - _________ 25.";
	static string pr38 ="Complete la oración:\nCuando ______  por la calle, me encontré con Pedro.";
	static string pr39 ="Complete la oración:\nEl verano que viene _______________ al Caribe.";
	static string pr40 ="Complete la oración:\n¡_______ has llegado! Hace horas que te esperábamos.";
	static string pr41 ="Complete la oración:\nAntes, en España la gente no ______ tantas libertades.";
	static string pr42 ="Complete la oración:\nSi me ______ una moto, te prometo que ______ mucho.";
	static string pr43 ="Complete la oración:\nSi quieres ver esa película, ______ al cine esta noche.";
	static string pr44 ="Complete la oración:\nOjalá ____________ Elena esta noche a la fiesta.";
	static string pr45 ="Complete la oración:\nTe veré cuando _____________ a Barcelona.";

	//Continuacion de matematicas parte 2
	static string pr46 = "Si 15 es el 30% de y, entonces y equivale a";
	static string pr47 = "Los elementos de una proporción son:";
	static string pr48 = "Los ángulos menores a 90° son:";
	static string pr49 = "Los triángulos con sus lados iguales son:";
	static string pr50 = "El conjunto de los números reales está formado\npor los números:";

	//Preguntas de Ciencias sociales
	static string pr51 = "¿Cuales eran las principales cosas que carecían?";
	static string pr52 = "¿Aquien culpaba la burguesía de los males de\nla economía?";
	static string pr53 = "¿En cuántas regiones naturales está dividido nuestro país?";
	static string pr54 = "¿Cuál es la flor nacional de Colombia?";
	static string pr55 = "¿De las tres cordilleras que atraviesan el territorio\ncolombiano cuál es la más extensa? ";

	public static List<string> preguntas = new List<string>(){pr1, pr2, pr3, pr4, pr5,pr6,pr7,pr8,pr9,pr10,pr11,pr12,pr13,pr14,pr15,pr16,pr17,pr18,pr19,pr20,pr21,pr22,pr23,pr24,pr25,pr26,pr27,pr28,pr29,pr30,pr31,pr32,pr33,pr34,pr35,pr36,pr37,pr38,pr39,pr40,pr41,pr42,pr43,pr44,pr45,pr46,pr47,pr48,pr49,pr50,pr51,pr52,pr53,pr54,pr55};

	public static List<string> respuestas = new List<string>(){"Respuesta1", "Respuesta2", "Respuesta2", "Respuesta4",
		"Respuesta2","Respuesta2","Respuesta3","Respuesta1","Respuesta4","Respuesta1","Respuesta2","Respuesta4","Respuesta1","Respuesta1",
		"Respuesta2","Respuesta3","Respuesta2","Respuesta4","Respuesta4","Respuesta3","Respuesta1","Respuesta3","Respuesta1",
		"Respuesta2","Respuesta4","Respuesta2","Respuesta3","Respuesta3","Respuesta1","Respuesta2","Respuesta4","Respuesta2",
		"Respuesta1","Respuesta2","Respuesta2","Respuesta3","Respuesta3","Respuesta4","Respuesta3","Respuesta1","Respuesta3","Respuesta1",
		"Respuesta3","Respuesta3","Respuesta3","Respuesta3","Respuesta3","Respuesta2","Respuesta1","Respuesta1","Respuesta2","Respuesta1",
		"Respuesta4","Respuesta1","Respuesta3"};


	//List<int> preguntaAnterior = new List<int>(){-1,-1,-1,-1};
	public static int numeroPregunta = 0;

	public static int preguntaRandom = -1;
	public static string RespuestaSeleccionada;
	public static string Seleccionada = "n";
	public static int preguntasCorrectas = 0;
	public static int totalPreguntas = 0;


	public void Update ()
	{

		if (preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = preguntas [preguntaRandom];

		} 

		if (preguntaRandom == -1) {
			preguntaRandom = Random.Range (0, 55);
			print(preguntaRandom + "if");

		}




	}
}

