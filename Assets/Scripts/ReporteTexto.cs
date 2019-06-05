using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ReporteTexto : MonoBehaviour {

	public Text txtReporte;
	
	int totalPreguntasPorArea;
	int totalPreguntas;

	double porcentajeM;
	double porcentajeC;
	double porcentajeL;
	double porcentajeS;

	double porcentajeTotal;
	
	public void Start(){

		int correctasM = PlayerPrefs.GetInt ("contadorMatematicasCorrectas");
		int incorrectasM = PlayerPrefs.GetInt ("contadorMatematicasIncorrectas");
		int correctasC = PlayerPrefs.GetInt ("contadorCienciasCorrectas");
		int incorrectasC = PlayerPrefs.GetInt ("contadorCienciasIncorrectas");
		int correctasL = PlayerPrefs.GetInt ("contadorLenguajeCorrectas");
		int incorrectasL = PlayerPrefs.GetInt ("contadorLenguajeIncorrectas");
		int correctasS = PlayerPrefs.GetInt ("contadorSocialesCorrectas");
		int incorrectasS = PlayerPrefs.GetInt ("contadorSocialesIncorrectas");

		int totalPreguntasCorrectas= correctasM + correctasC + correctasL + correctasS;
		int totalPreguntasIncorrectas = incorrectasC + incorrectasM + incorrectasL + incorrectasS;

		totalPreguntas = 8;
		totalPreguntasPorArea = 2;
	
		porcentajeTotal = (totalPreguntasCorrectas * 100)/totalPreguntas;
		porcentajeM = (correctasM * 100)/totalPreguntasPorArea;
		porcentajeC = (correctasC * 100)/totalPreguntasPorArea;
		porcentajeL = (correctasL * 100)/totalPreguntasPorArea;
		porcentajeS = (correctasS* 100)/totalPreguntasPorArea;

	
		string nombreM= PlayerPrefs.GetString ("nombreEstudiante");

		txtReporte.text = nombreM + ", su desempeño en la prueba fue de: " + porcentajeTotal + "%" + "\n" +
									"Obteniendo un total de " + totalPreguntasCorrectas + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + totalPreguntasIncorrectas + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Matemáticas su desempeño fue de: " + porcentajeM + "%" + "\n" +
									"Obteniendo un total de " + correctasM + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasM + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Ciencias su desempeño fue de: " + porcentajeC + "%" + "\n" +
									"Obteniendo un total de " + correctasC + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasC + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Lenguaje su desempeño fue de: " + porcentajeL + "%" + "\n" +
									"Obteniendo un total de " + correctasL + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasL + " preguntas contestadas incorrectamente" + "\n" + "\n" +

									"En el área de Sociales su desempeño fue de: " + porcentajeS + "%" + "\n" +
									"Obteniendo un total de " + correctasS + " preguntas contestadas correctamente" + "\n" +
									"y un total de " + incorrectasS + " preguntas contestadas incorrectamente" + "\n" + "\n";
		
		
	}
	public void generar () {
		//Nombre del estudiante
     	string nombreEstudiante = PlayerPrefs.GetString ("nombreEstudiante");
		string apellidoEstudiante = PlayerPrefs.GetString ("apellidoEstudiante");
		
		//Direccion de la ruta para crear la carpeta
		string ruta = Application.dataPath + "/Reportes/"+ nombreEstudiante + apellidoEstudiante;
		//Direccion de la ruta para crear el archivo dentro de la carpeta
		string reporte = Application.dataPath + "/Reportes/"+ nombreEstudiante + apellidoEstudiante + "/reporte.txt";

		//Se verifica si la ruta existe
		if (!Directory.Exists (ruta)) {
			//De no existir, se crea el directorio
			Directory.CreateDirectory (ruta);
			//se verifica si exite el archivo
			if(!File.Exists(reporte)){
				//De no existir, se crea el archivo
				File.WriteAllText(reporte ,"Hola soy reporte \n");
			}else{
				//De existir el archivo, se agrega nuevas lineas al archivo
				File.AppendAllText(reporte ,"Hola soy reporte 2 \n");
			}
		}else{
			//se verifica si exite el archivo
			if(!File.Exists(reporte)){
			//De no existir, se crea el archivo
			File.WriteAllText(reporte ,"Hola soy reporte \n");
			}else{
				//De existir el archivo, se agrega nuevas lineas al archivo
				File.AppendAllText(reporte ,"Hola soy reporte 3 \n");
			}
		}
		
	}
}