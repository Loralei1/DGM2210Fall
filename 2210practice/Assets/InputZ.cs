using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputz : MonoBehaviour
{

	[CreateAssetMenu]

	public class InputZ : InputBase

	{

		public string InputName = "Vertical";

		public float FloatValue = 1;

		public override float MoveInput()

		{

			return Input.GetAxis(InputName);

		}

	}
}
