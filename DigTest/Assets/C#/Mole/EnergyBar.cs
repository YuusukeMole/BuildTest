using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour 
{
	private Slider energyslider;
	private StatusMole statusmole;
	private float energy;

	void Start () 
	{
		energyslider = GameObject.Find ("MoleEnergySlider").GetComponent<Slider> ();
		statusmole = GameObject.Find ("mole").GetComponent<StatusMole> ();
	}

	void Update () {
		energy = statusmole.Energy / 20f;
		energyslider.value = energy;
	}
}
