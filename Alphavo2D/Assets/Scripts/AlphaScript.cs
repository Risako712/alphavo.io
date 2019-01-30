using UnityEngine;
using System.Collections;

public class AlphaScript : MonoBehaviour {

	//public Animator AlphaAnimator;
	//public Animator PhraseAnimator;

	// Use this for initialization
	void Start () {

		//AlphaAnimator = GetComponent<Animator> ();
		GetComponent<CanvasRenderer>().SetAlpha(0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClicked () {

		//AlphaAnimator.CrossFade("Alpha-Animation", 0.3f);

		//AlphaAnimator.SetBool("Alpha-Animation", true);
		//GetComponent<Image>().enabled = true;
		GetComponent<CanvasRenderer>().SetAlpha(20);
		//Debug.Log("bbb");
		

	}
}
