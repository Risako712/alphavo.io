using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EorH : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Easy () {
		Application.LoadLevel(4);
	}

	public void Hard () {

		Application.LoadLevel(5);

	}
}
