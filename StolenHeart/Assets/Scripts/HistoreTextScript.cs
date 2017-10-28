using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class HistoreTextScript : MonoBehaviour {

	public Text historeText;

	void Start () {
		
	}
	

	void Update () {	
		if (Input.GetMouseButtonDown (0)) {
				historeText.text = "Привет игрок";
		}
			/*
			if (Input.GetMouseButtonUp (0)){
				historeText.text = "Что бы вернуть преждную жизнь \n ты должен найти кто это сделал и убить его...";
			}
			if (Input.GetMouseButtonUp (0)) {
				historeText.text = "Никогда не сдавайся идти только вперед... \n Нажми 'S' для старта игры...";
			}
			if (Input.GetMouseButtonUp (0)){
				EditorSceneManager.LoadScene (1);
			}
			*/
		}

			
	}
}
