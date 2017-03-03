using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMole : MonoBehaviour 
{
	public GameObject MoleAttakcGameObject;
	public StatusMole statusmole;

	void Start()
	{
		statusmole = GetComponent<StatusMole> ();
	}

	void Update () 
	{
		if (statusmole.Energy > 0) {
			if (Input.GetKeyDown (KeyCode.A)) {
				Instantiate (MoleAttakcGameObject, new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
				statusmole.Energy -= 1.0f;
			}
		}
	}
}
