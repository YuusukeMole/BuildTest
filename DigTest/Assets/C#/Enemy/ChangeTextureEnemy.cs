using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextureEnemy : MonoBehaviour {
	public Material OriginalMaterial;
	public Material DamageMaterial;
	private Renderer gameobjectrenderer;
	private int damageflag = 0;
	private float damagetime = 1.0f;

	void Start()
	{
		gameobjectrenderer = GetComponent<Renderer> ();
	}

	void Update()
	{
		if (damageflag == 1) {
			damagetime -= Time.deltaTime;
			if (damagetime < 0) {
				gameobjectrenderer.material.color = OriginalMaterial.color;
				damageflag = 0;
				damagetime = 1.0f;
			}
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		var other = collision.gameObject;
		if (other.layer == 11) {
			gameobjectrenderer.material.color = DamageMaterial.color;
			damageflag = 1;
		} else {
			gameobjectrenderer.material.color = OriginalMaterial.color;
			damageflag = 0;
		}
	}

	void OnCollisionExit(Collision collision)
	{
		gameobjectrenderer.material.color = OriginalMaterial.color;
		damageflag = 0;
	}


}
