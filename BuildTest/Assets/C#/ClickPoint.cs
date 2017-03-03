using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPoint : MonoBehaviour 
{
	private Vector2 clickvector;

	public Vector2 ClickVector
	{
		get 
		{
			return clickvector;
		}
	}



	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			clickvector = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//Debug.Log ("x=" + clickvector.x + "y=" + clickvector.y);
		}
	}
}
