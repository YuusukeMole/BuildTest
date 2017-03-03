using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttaclMoleCollider : MonoBehaviour 
{
	private  float AttackTime = 0.5f;
	void Update () 
	{
		AttackTime -= Time.deltaTime;
		if (AttackTime < 0) {
			Destroy (this.gameObject);
		}
	}

	void  OnCollisionEnter(Collision collision)
	{			
		GameObject other = collision.gameObject;
		if (other.layer == 9) {
			StatusEnemy enemy = other.GetComponent<StatusEnemy> ();
			enemy.EnemyHP -= 2;

		} else {
			Destroy (other);
		}
	}
}
