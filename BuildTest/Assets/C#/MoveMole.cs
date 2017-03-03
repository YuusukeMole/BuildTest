using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMole : MonoBehaviour 
{
	private Vector2 destination;
	private float movespeed=1.5f;
	private StatusMole statusmole;


	public Vector2 Destination 
	{
		get 
		{
			return destination;
		}
	}

	void Start () 
	{
		destination.x = this.gameObject.transform.position.x;
		destination.y = this.gameObject.transform.position.y;
		statusmole = GetComponent<StatusMole> ();

	}

	void Update () 
	{
			if (Input.GetMouseButtonDown (0)) {
				destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			}

			if (statusmole.Energy > 0) {
				transform.position = Vector2.MoveTowards (transform.position, new Vector2 (destination.x, destination.y), movespeed * Time.deltaTime);
			}
	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject other = collision.gameObject;
		if (other.layer == 8) {
			Destroy (other);
		}

	}
}
