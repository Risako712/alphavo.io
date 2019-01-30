using UnityEngine;
using System.Collections;

public class ToGameMode : MonoBehaviour {


	void Start () {

		Invoke("DelayMethod", 9.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void DelayMethod(){

		Application.LoadLevel(3);

	}
}
