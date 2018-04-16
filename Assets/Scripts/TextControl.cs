using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControl : MonoBehaviour {

	List<string> preguntas = new List<string>(){"primera pregunta", "segunda pregunta", "tercera pregunta", "cuarta pregunta"};
	public int preguntaRandom = -1;
	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = preguntas [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (preguntaRandom == -1) {
			preguntaRandom = Random.Range (0, 3);
		}
		if (preguntaRandom > -1) {
			GetComponent<TextMesh> ().text = preguntas [preguntaRandom];
		}
	}
}
