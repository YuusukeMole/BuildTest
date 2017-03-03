using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEnemy : MonoBehaviour 
{
	private int HP = 50;	//デモ用に低めの設定に変更
	private float enemyenergy = 20.0f;
	private float breaktime=0.0f;
	private MoveEnemy moveenemy;
	private ReturnTitle returntitle;
	private Vector2 destination;
	public GameObject GameClearText;

	public int EnemyHP
	{
		get {
			return HP;
		}
		set {
			HP = value;
		}
	}

	public float EnemyEnergy 
	{
		get {
			return enemyenergy;
		}
		set {
			enemyenergy = value;
		}
	}

	void Start()
	{
		moveenemy = GetComponent<MoveEnemy> ();
		returntitle = GameObject.Find ("Main Camera").GetComponent<ReturnTitle> ();
	}

	void Update () 
	{
		if (HP <= 0) {
			GameClearText.SendMessage ("Clear");
			returntitle.GameFlag = 1;
			Destroy (this.gameObject);
		}

		destination = moveenemy.EnemyDestination;
		if (enemyenergy > 0.0f) {
			if (destination.x != this.gameObject.transform.position.x　 || destination.y != this.gameObject.transform.position.y) {
				enemyenergy -= 1.0f * Time.deltaTime;
			} else {
				if (enemyenergy < 20.0f) {
					enemyenergy += 0.5f * Time.deltaTime;
				} else {
					enemyenergy = 20.0f;
				}
			}
		} else {
			if (breaktime < 10.0f) {
				breaktime += 1.0f * Time.deltaTime;
			} else {
				enemyenergy = 20.0f;
				breaktime = 0.0f;
			}
		}
	}
}
