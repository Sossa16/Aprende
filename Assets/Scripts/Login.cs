using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

	public InputField campoId;
	public InputField campoContrasenia;
	string idProfesor;
	string contrasenia;
	public Text txtError;

	void awake(){
		DontDestroyOnLoad (gameObject);
	}

	public void guardar(string pnombreescena){
		idProfesor = campoId.text;
		contrasenia = campoContrasenia.text;

		if (idProfesor == "001" && contrasenia == "001") {

			SceneManager.LoadScene (pnombreescena);
			PlayerPrefs.SetString ("nombre", contrasenia);
			PlayerPrefs.SetString ("idProfesor", idProfesor);
		} else {
			if (idProfesor != "001" || contrasenia != "001") {
				txtError.text = "Usuario o contraseña incorrectos";
			}
			
			if (idProfesor == "" && contrasenia == "") {
				txtError.text = "Rellene todos los campos";

			}


		}
}
}