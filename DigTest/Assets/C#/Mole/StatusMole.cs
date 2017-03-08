using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusMole : MonoBehaviour 
{
	private float HP=100.0f;
	private float energy=20.0f;
	private float breaktime =0.0f;
	private MoveMole movemole;
	private ReturnTitle returntitle;
	private Vector2 destination;
	private Vector2 currentpoint;
	public GameObject GameOverText;
	public GameObject BreakText;

	public float MoleHP
	{
		get{
			return HP;
		}
		set{
			HP = value;
		}
	}
			

	public float Energy 
	{
		get 
		{
			return energy;
		}

		set 
		{
			energy = value;
		}
	}

	public float BreakTime
	{
		get
		{
			return breaktime;
		}
	}


	public Vector2 CurrentPoint 
	{
		get 
		{
			return currentpoint;
		}
	} 

	void Start()
	{
		movemole = GetComponent<MoveMole> ();
		returntitle = GameObject.Find ("Main Camera").GetComponent<ReturnTitle> ();
	}

	void Update ()
	{
		if (HP <= 0) {
			GameOverText.SendMessage ("Over");
			returntitle.GameFlag = 1;
			Destroy (this.gameObject);

		}
		destination = movemole.Destination;
		currentpoint = this.gameObject.transform.position;

		if (energy > 0.0f) {//エネルギーがあるなら
			if (destination.x != currentpoint.x　 || destination.y != currentpoint.y) {//移動しているなら
				energy -= 1.0f * Time.deltaTime;	
			} else {//移動してないなら
				if (energy < 20.0f) {//エネルギーが回復してないなら
					energy += 1.0f * Time.deltaTime;//回復
				} else {//エネルギーが最大値をこえていたら
					energy = 20.0f;//最大値に戻す
				}
			}
		}else{//エネルギーがないならbreaktime
			
			BreakText.SendMessage ("Break");
			if (breaktime < 10.0f) {
				breaktime += 1.0f * Time.deltaTime;
			} else {
				
				BreakText.SendMessage ("Charge");
				energy = 20.0f;
				breaktime = 0.0f;
			}
		}
	}
}
	
