using UnityEngine;
using System.Collections;

public class StartText : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject.FindWithTag("AstandbyText").GetComponent<UnityEngine.UI.Text>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
				GameObject.FindWithTag("AstandbyText").GetComponent<UnityEngine.UI.Text>().enabled = false;
	
	}
}
