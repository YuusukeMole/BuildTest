using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour 
{
	private Vector2 enemydestination;
	private float enemyspeed = 1.5f;
	private float behaviorinterval =2.0f;
	private StatusEnemy statusenemy;

	public Vector2 EnemyDestination 
	{
		get 
		{
			return enemydestination;
		}
	}

	void Start()
	{
		statusenemy = GetComponent<StatusEnemy> ();
	}

	void Update()
	{
		behaviorinterval -= Time.deltaTime;
		if (statusenemy.EnemyEnergy > 0) {
			if (behaviorinterval < 0) {
				enemydestination.x = Random.Range (0.3f, 17.5f);
				enemydestination.y = Random.Range (0.3f, 9.5f);
				behaviorinterval = 2.0f;
			} else {
				transform.position = Vector2.MoveTowards (transform.position, new Vector2 (enemydestination.x, enemydestination.y), enemyspeed * Time.deltaTime);
			}
		}
	}
}
