﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarDatos : MonoBehaviour {

	public Text txtBienvenida;

	// Use this for initialization
	void Start () {
		string nombreM= PlayerPrefs.GetString ("nombre", "No hay nada");
		txtBienvenida.text = "Bienvenido " + nombreM;
		print ("entro");
	}

}