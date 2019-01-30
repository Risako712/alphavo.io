using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIrenderer : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if ( GameObject.FindWithTag("PreviousUI") != null ) {
			GameObject.FindWithTag("PreviousUI").GetComponent<UnityEngine.UI.Image>().enabled = false;
		}
		GameObject.FindWithTag("AstandbyUI").GetComponent<UnityEngine.UI.Image>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClicked () {

		GameObject.FindWithTag("NowUI").tag = ("PreviousUI");

		if ( GameObject.FindWithTag("PreviousUI") != null ) {
			
			GameObject.FindWithTag("PreviousUI").GetComponent<UnityEngine.UI.Image>().enabled = false;
			GameObject.FindWithTag("PreviousUI").tag = ("AstandbyUI");

		}



		this.tag = ("NowUI");

		GameObject.FindWithTag("NowUI").GetComponent<UnityEngine.UI.Image>().enabled = true;

	}
}
