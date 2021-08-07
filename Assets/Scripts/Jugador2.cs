using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour
{
	public float speed = 6.0f; // velocidad
	public float jumpSpeed = 8.0f; // salto, cambia esta variable para saltar mas alto
	public float gravity = 20.0f; // salto, cambia esta variable para saltar mas alto
	public float rotationSpeed = 100.0f; //Rotacion camera sensibilidad

	private Vector3 moveDirection = Vector3.zero;

	void Update()
	{

		CharacterController controller = GetComponent<CharacterController>();

		if (controller.isGrounded)
		{

			moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical2"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			float rotation = Input.GetAxis("Horizontal2") * rotationSpeed;
			rotation *= Time.deltaTime;
			transform.Rotate(0, rotation, 0);


			if (Input.GetButton("Jump2"))
			{
				moveDirection.y = jumpSpeed;
			}

		}

		moveDirection.y -= gravity * Time.deltaTime;

		controller.Move(moveDirection * Time.deltaTime);
	}
}
