using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarDatos : MonoBehaviour {

	public Text txtBienvenida;
	// Use this for initialization
	public void Start () {
		string nombreEstudiante = PlayerPrefs.GetString ("nombreEstudiante");
		txtBienvenida.text = "Bienvenido(a) \n" + nombreEstudiante;

	}

}
