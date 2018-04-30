using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarDatos : MonoBehaviour {

	public Text txtBienvenida;

	// Use this for initialization
	public void Start () {
		string nombreM= PlayerPrefs.GetString ("nombre");
		txtBienvenida.text = "Bienvenido \n" + nombreM;

	}

}
