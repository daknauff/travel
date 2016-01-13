using UnityEngine;
using System.Collections;

public class Test_QuitGame : MonoBehaviour {

	public void quitGame(){
	#if UNITY_EDITOR
	UnityEditor.EditorApplication.isPlaying = false;
	#else
	Application.Quit();
	#endif

	}

}
