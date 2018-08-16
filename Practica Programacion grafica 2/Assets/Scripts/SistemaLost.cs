using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaLost : MonoBehaviour {

	public void reinicio()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    public void salida()
    {
        Application.Quit();
    }
}