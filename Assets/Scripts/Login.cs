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

	void awake(){
		DontDestroyOnLoad (gameObject);
	}

	public void guardar(string pnombreescena){
		idProfesor = campoId.text;
		contrasenia = campoContrasenia.text;


			if(idProfesor == "001" && contrasenia == "001"){
			SceneManager.LoadScene (pnombreescena);
			PlayerPrefs.SetString ("nombre", contrasenia);
			PlayerPrefs.SetString ("idProfesor", idProfesor);

		} else {
			print("Usuario o contraseña incorrecta");
		}

	}
}
