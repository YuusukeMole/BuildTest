using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour 
{
	public int GameFlag =0;

	void Update()
	{
		if (GameFlag == 1) {
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("title");
			}

		}
	}


}
