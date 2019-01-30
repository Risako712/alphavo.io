using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BlockScript : MonoBehaviour {


	// Use this for initialization
	void Start () {


		GameObject.FindWithTag("GAME").GetComponent<Canvas>().enabled = false;
		Debug.Log("kitayon");
		Invoke("DelayMethod", 14f);





	
	}
	
	// Update is called once per frame
	void Update () {


		//Debug.Log("kokoja");



	
	}

	void DelayMethod(){

		GameObject.FindWithTag("GAME").GetComponent<Canvas>().enabled = true;
		GameObject.FindWithTag("STUDY").GetComponent<Canvas>().enabled = false;
	    Debug.Log("Delay call");
	}

	public void skipMethod(){

		GameObject.Find("Setsumei").GetComponent<Renderer>().enabled = false;

		Invoke("DelayMethod",0.5f);


	}
}
