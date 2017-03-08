using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

	public Rigidbody BarrelPrefub;
	public Transform BarrelTransForm;
	private StatusMole statusmole;

	void Start()
	{
		statusmole = GetComponent<StatusMole> ();
	}

	void Update()
	{
		if (statusmole.Energy > 0) {
			if (Input.GetKeyDown (KeyCode.S)) {
				Rigidbody rocketbarrel;
				rocketbarrel = Instantiate (BarrelPrefub, BarrelTransForm.position, BarrelTransForm.rotation)as Rigidbody;
				rocketbarrel.AddForce (BarrelTransForm.up * 500);
				statusmole.Energy -= 1.0f;
			}
		}
	}
}
