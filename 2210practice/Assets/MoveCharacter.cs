using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {



	public CharacterController controller; 

	public MovePattern MovePattern;

	public Player Player; 







	public void Start ()

	{

		controller = GetComponent<CharacterController>(); 

	}



	void Update ()

	{

		Player.MovePattern.Move(controller, transform);

	} 

}