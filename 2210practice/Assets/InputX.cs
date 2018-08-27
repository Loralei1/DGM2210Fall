using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class InputX : InputBase 

{

	public string InputName = "Horizontal";

	public float FloatValue = 1;

	public override float MoveInput()

	{

		return Input.GetAxis (InputName);

	}

}
