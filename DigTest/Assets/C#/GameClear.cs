using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameClear : MonoBehaviour 
{

	void Start () 
	{
		this.gameObject.GetComponent<Text> ().enabled = false;
	}

	public void Clear()
	{
		this.gameObject.GetComponent<Text> ().enabled = true;
	}
}
