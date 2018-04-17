using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

	public InputField campoID;
	public InputField campoContrasenia;
	string guardarId;
	string guardarContrasenia;



	public void login(){
		string id = campoID.text;
		string contrasenia = campoContrasenia.text;
		PlayerPrefs.SetString ("ID", id);
		PlayerPrefs.SetString ("Contrasenia", contrasenia);
		guardarId = PlayerPrefs.GetString ("ID");
		guardarContrasenia = PlayerPrefs.GetString ("Contrasenia");

	}
	public void comparacion(string pnombreescena){
		if (guardarId.Equals ("Santiago")) {
			SceneManager.LoadScene (pnombreescena);
		} 
		else {
			print ("No entra");
		}

	}
}
