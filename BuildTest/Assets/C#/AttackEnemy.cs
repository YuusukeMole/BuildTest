using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour 
{
	public GameObject EnemyAttakcGameObject;
	private StatusEnemy statusenemy;

	void Start () 
	{
		statusenemy = GetComponent<StatusEnemy> ();
	}
		
	void OnCollisionEnter(Collision collision)
	{
		GameObject other = collision.gameObject;
		if (statusenemy.EnemyEnergy > 0) {
			if (other.layer == 10) {
				Instantiate (EnemyAttakcGameObject, new Vector2 (this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);
				statusenemy.EnemyEnergy -= 1.0f;
			}
		}
			
	}
}
