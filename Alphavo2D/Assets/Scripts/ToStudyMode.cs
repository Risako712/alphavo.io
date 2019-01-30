using UnityEngine;
using System.Collections;

public class ToStudyMode : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Invoke("DelayMethod", 12.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void DelayMethod(){

		Application.LoadLevel(2);

	}
}
