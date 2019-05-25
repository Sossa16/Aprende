using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ManejoJuego : MonoBehaviour
{
  [SerializeField] private AudioClip sonidoCorrecto = null;

  [SerializeField] private AudioClip sonidoIncorrecto = null;

  [SerializeField] private Color colorCorrecto = Color.black;

  [SerializeField] private Color colorIncorrecto = Color.black;

  [SerializeField] private float tiempoEspera = 0.0f;

  private PreguntasDB preguntasDB = null;

  private PreguntasUI preguntasUI = null;

  private AudioSource fuenteAudio = null;

   int contador = 0;
   
  private void Start(){

    preguntasDB = GameObject.FindObjectOfType<PreguntasDB>();

    preguntasUI = GameObject.FindObjectOfType<PreguntasUI>();

    fuenteAudio = GetComponent<AudioSource>();
    
      siguientePregunta();
    
  }
  
  private void siguientePregunta(){
    preguntasUI.constructor(preguntasDB.GetRandom() , darRespuesta);
  }
 
  private void darRespuesta(SeleccionarRespuesta seleccionarRespuesta){

    StartCoroutine(darCaracteristicaRespuesta(seleccionarRespuesta));
    
  }

  private IEnumerator darCaracteristicaRespuesta(SeleccionarRespuesta seleccionarRespuesta){

    if(fuenteAudio.isPlaying)
      fuenteAudio.Stop();
    

    fuenteAudio.clip = seleccionarRespuesta.Opcion.correcta ? sonidoCorrecto : sonidoIncorrecto;
    seleccionarRespuesta.setColor(seleccionarRespuesta.Opcion.correcta ? colorCorrecto : colorIncorrecto);
    
    fuenteAudio.Play();
    if(seleccionarRespuesta.Opcion.correcta){
          contador++;
          
          Debug.Log("Este es el contador en manejo " + contador); 
      }

    PlayerPrefs.SetInt ("contador", contador);

    yield return new WaitForSeconds(tiempoEspera);

    yield return contador;

    siguientePregunta();
  } 

  
  


}
