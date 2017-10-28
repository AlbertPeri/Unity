using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class ButtonScripts : MonoBehaviour {

	public void Restart (){
		EditorSceneManager.LoadScene (1);
	}
}
