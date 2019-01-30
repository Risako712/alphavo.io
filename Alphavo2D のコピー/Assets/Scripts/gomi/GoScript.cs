using UnityEngine;
using System.Collections;

public class GoScript : MonoBehaviour {

	public Animator EditorAnimator;
	//public Animator KakoAnimator;

	// Use this for initialization
	void Start () {

		EditorAnimator = GetComponent<Animator>();
		//KakoAnimator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClicked () {

		//GameObject.FindWithTag("IMA").tag = ("KAKOMAE");
		GameObject.FindWithTag("IMA").GetComponent<Animator>().SetBool("Go", false);
		GameObject.FindWithTag("IMA").transform.position = new Vector3(2178,-297,0);



		Debug.Log("kako");
		GameObject.FindWithTag("IMA").tag = ("KAKO");


		EditorAnimator.SetBool("Go", true);
		this.tag = ("IMA");

	}
}
