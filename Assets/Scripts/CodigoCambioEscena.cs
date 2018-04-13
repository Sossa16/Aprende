using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodigoCambioEscena : MonoBehaviour {

	public void cargarEscenas(string pnombreescena){
		SceneManager.LoadScene (pnombreescena);
	}
		
}
