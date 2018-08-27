using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class JumpInput : InputBase {



	public string InputName = "Jump";

	public float FloatValue = 1;



	public override float MoveInput()

	{

		return Input.GetButton (InputName) ? FloatValue : 0;

	}





}


