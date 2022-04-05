using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    bool triggered = false;

    public AudioSource Sonido;

    public void PlaySonido()
    {
        Sonido.Play();
    }
    public void OnTriggerEnter (Collider collider)
    {
        if(triggered != true)
        {
                PlaySonido();
                triggered = true;
        }
    }
}
