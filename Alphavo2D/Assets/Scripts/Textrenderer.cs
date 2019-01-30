using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Textrenderer : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject.FindWithTag("PreviousText").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.FindWithTag("AstandbyText").GetComponent<UnityEngine.UI.Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClicked () {


		GameObject.FindWithTag("PreviousText").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.FindWithTag("PreviousText").tag = ("AstandbyText");

		this.tag = ("PreviousText");
		
		GameObject.FindWithTag("PreviousText").GetComponent<UnityEngine.UI.Text>().enabled = true;




	}
}
