using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovilLateral : MonoBehaviour
{

	//Velocidad de movimiento
	[Range(1, 10)]
	public float velocidad = 3;

	//Direccion del movimiento
	private Vector3 direccion = Vector3.left;

	//L�mites de movimiento
	private int limiteSuperior = 5;
	private int limiteInferior = 1;

	void Update()
	{

		//Si alcanza el l�mite superior, direcci�n bajada
		if (transform.position.x >= limiteSuperior)
		{
			direccion = Vector3.left;
		}

		//Si alcanza el l�mite inferior, direcci�n subida
		if (transform.position.x <= limiteInferior)
		{
			direccion = Vector3.right;
		}

		//Traslada la plataforma en cada frame a la velocidad y direcci�n indicadas
		transform.Translate(direccion * Time.deltaTime * velocidad);

	}
}
