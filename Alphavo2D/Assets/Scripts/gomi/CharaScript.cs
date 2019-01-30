using UnityEngine;
using System.Collections;

public class CharaScript : MonoBehaviour {

	public Animator CharaAnimator;
	//public Animator PhraseAnimator;

	// Use this for initialization
	void Start () {

		CharaAnimator = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
	        Vector2 tapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	        Collider2D collider = Physics2D.OverlapPoint (tapPoint);
	        if (collider != null) {
	            GameObject obj = collider.transform.gameObject;
	            Destroy (obj);
	        }
        }
	
	}


	public void ButtonClicked () {

		//AlphaAnimator.CrossFade("Alpha-Animation", 0.3f);

		CharaAnimator.SetBool("Chara-Animation", true);
		Debug.Log("bbb");
		

	}
}

