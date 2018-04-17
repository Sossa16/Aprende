using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegistroEstudiante : MonoBehaviour {

	public InputField campoNombre;
	public InputField campoIdProfesor;
	string idProfesor;
	string nombre;

	public void awake(){
		DontDestroyOnLoad (gameObject);
	}

	public void guardar(string pnombreescena){
		idProfesor = campoIdProfesor.text;
		nombre = campoNombre.text;

		if (idProfesor != "" && nombre != "") {
			SceneManager.LoadScene (pnombreescena);
			PlayerPrefs.SetString ("nombre", nombre);
			PlayerPrefs.SetString ("idProfesor", idProfesor);

		} else {
			print("Error en campos");
		}

	}

		
}
