using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegistroEstudiante : MonoBehaviour {

	public InputField campoNombre;
	public InputField campoIdProfesor;

	public void awake(){
		DontDestroyOnLoad (gameObject);
	}

	public void guardar(){
		string idProfesor = campoIdProfesor.text;
		string nombre = campoNombre.text;
		PlayerPrefs.SetString ("nombre", nombre);
		PlayerPrefs.SetString ("idProfesor", idProfesor);
	}
		
}
