using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour 
{
	private Slider slider;
	private float hp;
	private StatusMole statusmole;

	void Start () 
	{
		slider = GameObject.Find ("MoleHpSlider").GetComponent<Slider> ();
		statusmole = GameObject.Find ("mole").GetComponent<StatusMole> ();
	}
	

	void Update () 
	{
		hp = statusmole.MoleHP / 100f;

		slider.value = hp;
		
	}
}
