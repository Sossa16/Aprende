using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRespuestas : MonoBehaviour {
	public void OnMouseOver(){
		GetComponent<TextMesh> ().color = new Color (0, 1, 0);
	}

	public void OnMouseExit(){
		GetComponent<TextMesh> ().color = new Color (0, 0, 0);
	}
}
