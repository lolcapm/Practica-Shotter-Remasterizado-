using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverPlayer : MonoBehaviour {

    public float maxSalud;
    public float curSalud;
    public GameObject ui;

    // AudioSource playerAudio;


    void Awake()
    {
        //playerAudio = GetComponent<AudioSource>();

        curSalud = maxSalud;
    }
    void Update()
    {
        if (curSalud <= 0)
        {
            //playerAudio.clip = deathClip;
            //playerAudio.Play();
            SceneManager.LoadScene("Perdiste");
        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("ObjetoADestruir1"))
        {
            curSalud -= 10;
        }
    }
}
