using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MostrarRuta : MonoBehaviour
{
  public Text ruta;
  public void Start () {
        ruta.text = Application.dataPath;

  }
}
