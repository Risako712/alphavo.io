using UnityEngine;
using System.Collections;

public class StartUI : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject.FindWithTag("AstandbyUI").GetComponent<UnityEngine.UI.Image>().enabled = false;
		GameObject.FindWithTag("PreviousUI").GetComponent<UnityEngine.UI.Image>().enabled = false;
		Debug.Log("Start");
	
	}
	
	// Update is called once per frame
	void Update () {
		//GameObject.FindWithTag("AstandbyUI").GetComponent<UnityEngine.UI.Image>().enabled = false;
	
	}
}
