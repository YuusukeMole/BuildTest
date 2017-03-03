using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BreakText : MonoBehaviour 
{


	void Start () 
	{
		this.gameObject.GetComponent<Text> ().enabled = false;
	}

	public void Break()
	{
		this.gameObject.GetComponent<Text> ().enabled = true;
	}

	public void Charge()
	{
		this.gameObject.GetComponent<Text> ().enabled = false;
	}
}
