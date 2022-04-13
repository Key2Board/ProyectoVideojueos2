using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public int numeroEscena = 0;
    void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene(numeroEscena);
    }
}      

