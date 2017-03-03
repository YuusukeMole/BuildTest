using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakTimeBar : MonoBehaviour 
{
	private Slider breaktimeslider;
	private StatusMole statusmole;
	private float breaktime;

	void Start () 
	{
		breaktimeslider = GameObject.Find ("MoleBreakSlider").GetComponent<Slider> ();
		statusmole = GameObject.Find ("mole").GetComponent<StatusMole> ();
	}

	void Update () 
	{
		breaktime = statusmole.BreakTime / 10f;
		breaktimeslider.value = breaktime;
		
	}
}
