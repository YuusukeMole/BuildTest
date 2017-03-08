using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour 
{

	void Start () 
	{
		this.gameObject.GetComponent<Text> ().enabled = false;
	}

	public void Over()
	{
		this.gameObject.GetComponent<Text> ().enabled = true;
	}
}
