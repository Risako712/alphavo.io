using UnityEngine;
using System.Collections;

public class SorG : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void studyButton () {
		Application.LoadLevel(1);
	}

	public void gameButton () {
		Application.LoadLevel(6);
	}
}
