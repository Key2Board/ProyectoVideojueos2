using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{

	//Objeto Game Manager
	private GameManager gameManager;

	//Botones
	public Button botonInicio, botonJugar, botonOpciones, botonCreditos, botonSalir;

	void Start()
	{

		//Busco mi objeto Game Manager
		gameManager = FindObjectOfType<GameManager>();

		//A�ado al botonInicio la acci�n a ejecutar al hacer clic (cambiar a la escena Inicio desde el Game Manager)
		if (botonInicio)
		{
			botonInicio.GetComponent<Button>().onClick.AddListener(() => gameManager.cambiarEscena("Inicio"));
		}

		//A�ado al botonJugar la acci�n a ejecutar al hacer clic (cambiar a la escena Jugar desde el Game Manager)
		if (botonJugar)
		{
			botonJugar.GetComponent<Button>().onClick.AddListener(() => gameManager.cambiarEscena("Jugar"));
		}

		//A�ado al botonOpciones la acci�n a ejecutar al hacer clic (cambiar a la escena Opciones desde el Game Manager)
		if (botonOpciones)
		{
			botonOpciones.GetComponent<Button>().onClick.AddListener(() => gameManager.cambiarEscena("Opciones"));
		}

		//A�ado al botonCreditos la acci�n a ejecutar al hacer clic (cambiar a la escena Creditos desde el Game Manager)
		if (botonCreditos)
		{
			botonCreditos.GetComponent<Button>().onClick.AddListener(() => gameManager.cambiarEscena("Creditos"));
		}

		//A�ado al botonSalir la acci�n a ejecutar al hacer clic (salir de la aplicaci�n)
		//Este bot�n no funcionar� en el Editor de Unity, pero si al hacr el Build del Juego.
		if (botonSalir)
		{
			botonSalir.GetComponent<Button>().onClick.AddListener(() => Application.Quit());
		}

	}

}
