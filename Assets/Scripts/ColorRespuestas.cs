using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRespuestas : MonoBehaviour {
	public void OnMouseOver(){
		GetComponent<TextMesh> ().color = new Color (1, 1, 1);
	}

	public void OnMouseExit(){
		GetComponent<TextMesh> ().color = new Color (0, 0, 0);
	}
}
