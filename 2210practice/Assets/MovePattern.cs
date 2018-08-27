using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class MovePattern : ScriptableObject {



	public float speed = 6.0F;

	public float jumpSpeed = 8.0F;

	public float gravity = 10.0F;

	private Vector3 moveDirection = Vector3.zero;

	public InputBase InputX;

	public InputBase InputZ;

	public InputBase JumpInput;













	public void Move(CharacterController controller, Transform transform) 

	{ 



		if (controller.isGrounded) {



			moveDirection = transform.TransformDirection(moveDirection);

			moveDirection.x = InputX.MoveInput ();

			moveDirection *= speed;

			moveDirection.y = 0;

			moveDirection.z = InputZ.MoveInput ();

			moveDirection.y = JumpInput.MoveInput ();



		}



		controller.Move(moveDirection * Time.deltaTime);

		moveDirection.y -= gravity * Time.deltaTime;



		//while(Time < )







	}

}


