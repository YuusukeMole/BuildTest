using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMole : MonoBehaviour {
	private float bulletlifetime = 0.5f;

	void Update()
	{
		bulletlifetime -= Time.deltaTime;
		if (bulletlifetime <= 0) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		var other = collision.gameObject;
		if (other.layer == 8) {
			Destroy (other.gameObject);
		}else if (other.layer == 9) {
			StatusEnemy enemy = other.GetComponent<StatusEnemy> ();
			enemy.EnemyHP -= 1;

		}
		Destroy (this.gameObject);
	}

}
