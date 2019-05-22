using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
/**

Clase que permite gestionar las preguntas de la base de datos
@autor Santiago Cardozo Q
@autor Santiago Bedoya Ossa

 */
public class PreguntasDB : MonoBehaviour
{
    //Se crea una lista de preguntas
    [SerializeField] private List<Pregunta> listaPreguntas = null;

    /**
    Metodo que remueve las preguntas que ya salieron
    @param remove
    @return p
     */
    public Pregunta GetRandom(bool remove = true){
       
        if(listaPreguntas.Count == 0){    
        SceneManager.LoadScene ("ReporteEstudiante");
        }
        
        int index = Random.Range(0 , listaPreguntas.Count);  
        
        //Debug.Log("El index es" + index);
      
        // Se retornan la pregunta en la posicion index
        if(!remove)
            return listaPreguntas[index];
        
        //Se guarda la pregunta actual en p
        Pregunta p = listaPreguntas[index];
        //Una vez aparecio la pregunta, se remueve
        listaPreguntas.RemoveAt(index);
        //Se muestra la pregunta
        return p;
        
    
    }
    
}
