using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(LoadGame());
	}

	IEnumerator LoadGame() {
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(1);
	}
}
