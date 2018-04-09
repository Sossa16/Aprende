using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegistroEstudiante : MonoBehaviour {

	public InputField name;
	public InputField id;

	public void guardar(){
		string idProfesor = id.text;
		string nombre = name.text;
		PlayerPrefs.SetString ("nombre", nombre);
		PlayerPrefs.SetString ("idProfesor", idProfesor);
		print (nombre + " " + idProfesor);
	}

	public void imprimir(){
		PlayerPrefs.GetString ("nombre");
	}
}
