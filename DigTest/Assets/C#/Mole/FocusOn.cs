using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusOn : MonoBehaviour {
	private Vector2 destination;
	private float differenceY=0.0f;
	private float differenceX=0.0f;
	private float tangent;
	private float arctangent;
	private float tangentrotation;
	private float anglerotation;//回転角

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			differenceY = destination.y - this.gameObject.transform.position.y;
			differenceX = destination.x - this.gameObject.transform.position.x;

			tangent = differenceY / differenceX;//tanθのラジアン値
			arctangent = Mathf.Atan (tangent);//tanθからθへ変換

			tangentrotation = arctangent * 180.0f / Mathf.PI;//ラジアンから度に変換

			anglerotation = 90.0f - tangentrotation;//回転角＝180-90-tangentの角度

			if (differenceX >= 0) {
				anglerotation = anglerotation * -1;
			} else {
				anglerotation = 180.0f - anglerotation;
			}

			transform.rotation = Quaternion.Euler (0, 0, anglerotation);
		}


	}
}
