using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SmoothMoves;

public class CharaGetOut : MonoBehaviour {





	//BoneAnimation boneAnime = null;

	// Use this for initialization
	void Start () {

		GameObject.FindWithTag("PreviousChara").GetComponent<Renderer>().enabled = false;
		GameObject.FindWithTag("AstandbyChara").GetComponent<Renderer>().enabled = false;
		Debug.Log("aa");

		//boneAnime = GetComponent<BoneAnimation>();
	
	}
	
	// Update is called once per frame
	void Update () {


		// if (Input.GetMouseButtonDown (0)) {
	 //        Vector2 tapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	 //        Collider2D collider = Physics2D.OverlapPoint (tapPoint);

	 //        if (collider != null) {
	 //            GameObject obj = collider.transform.gameObject;

  //       		if (boneAnime != null && Random.value > 0.3f) {
  //           		boneAnime.Play("Idle");


            		//boneAnime = null;
	        	//}
	        //}
       // }

	
	}

	public void ButtonClicked () {

		//boneAnime.Stop("Idle");


		if(GameObject.FindWithTag("PreviousChara") != null){
			GameObject.FindWithTag("PreviousChara").GetComponent<Renderer>().enabled = false;
		}



		//GameObject.FindWithTag("AstandbyChara").GetComponent<Renderer>().enabled = false;
		//GameObject.FindWithTag("PreviousChara").tag = ("AstandbyChara");
		//this.tag = ("PreviousChara");
		// GameObject.FindWithTag("AstandbyChara").GetComponent<Renderer>().enabled = false;

		//GetComponent<Renderer>().enabled = true;

		//Debug.Log("kitayo");
	}






 }
