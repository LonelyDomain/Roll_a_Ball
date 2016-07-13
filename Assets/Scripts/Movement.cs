using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector3(-2, 4, 0);
	}

	// Update is called once per frame
	void Update () 
	{
		//Player to move left right up and down
		//Player (gameobject) aka transform to move when arrow keys are pressed

		transform.Translate(Vector3.right * Input.GetAxis("Horizontal"));
		transform.Translate(Vector3.forward * Input.GetAxis("Vertical"));
		transform.Translate(Vector3.up * Input.GetAxis("Jump"));
	}


}
       
