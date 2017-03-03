using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemyCollider : MonoBehaviour 
{
	private float attacktime = 0.5f;

	void Update ()
	{
		attacktime -= Time.deltaTime;
		if (attacktime < 0) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject other = collision.gameObject;
		if (other.layer == 10) {
			StatusMole mole = other.GetComponent<StatusMole> ();
			mole.MoleHP -= 0.5f;
		}
	}
}
