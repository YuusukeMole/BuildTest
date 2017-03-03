using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextureEnemy : MonoBehaviour {
	public Material OriginalMaterial;
	public Material DamageMaterial;
	private Renderer gameobjectrenderer;

	void Start()
	{
		gameobjectrenderer = GetComponent<Renderer> ();
	}
		
	void OnCollisionEnter(Collision collision)
	{
		var other = collision.gameObject;
		if (other.layer == 11) {
			gameobjectrenderer.material.color = DamageMaterial.color;
		} else {
			gameobjectrenderer.material.color = OriginalMaterial.color;
		}
	}

	void OnCollisionExit(Collision collision)
	{
		gameobjectrenderer.material.color = OriginalMaterial.color;
	}


}
