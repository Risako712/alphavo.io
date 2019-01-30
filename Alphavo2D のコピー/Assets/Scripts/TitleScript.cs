using UnityEngine;
using System.Collections;
using SmoothMoves;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour {

	BoneAnimation boneAnime = null;
	private AudioSource univoice;

	public AudioClip conga;
	public AudioClip back;

	// Use this for initialization
	void Start () {

		Invoke("DelayMethod", 2.5f);

		GameObject.FindWithTag("STUDY").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.FindWithTag("GAME").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.FindWithTag("STUDYimage").GetComponent<UnityEngine.UI.Image>().enabled = false;
		GameObject.FindWithTag("GAMEimage").GetComponent<UnityEngine.UI.Image>().enabled = false;
    	GameObject.Find("Canvas/touchme").GetComponent<UnityEngine.UI.Text>().enabled = false;



    }
	
	// Update is called once per frame
	void Update () {

		boneAnime = GetComponent<BoneAnimation>();
		if (Input.GetMouseButtonDown (0)) {
	        Vector2 tapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	        Collider2D collider = Physics2D.OverlapPoint (tapPoint);

	        if (collider != null) {
	            GameObject obj = collider.transform.gameObject;

        		if (boneAnime != null && Random.value > 0.3f) {
            		boneAnime.Play("Idle");

					if (GameObject.FindWithTag("STUDY").GetComponent<UnityEngine.UI.Text>().enabled != true) {
						conga_audio();
						back_audio();

						GameObject.FindWithTag("STUDY").GetComponent<UnityEngine.UI.Text>().enabled = true;
						GameObject.FindWithTag("GAME").GetComponent<UnityEngine.UI.Text>().enabled = true;
						GameObject.FindWithTag("STUDYimage").GetComponent<UnityEngine.UI.Image>().enabled = true;
						GameObject.FindWithTag("GAMEimage").GetComponent<UnityEngine.UI.Image>().enabled = true;
						GameObject.Find("Canvas/touchme").GetComponent<UnityEngine.UI.Text>().enabled = false;
					}






            	}
            }
        }
	
	}



	public void conga_audio (){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(conga);
	}

	public void back_audio (){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(back);
	}


	void DelayMethod(){

		if(	GameObject.FindWithTag("GAMEimage").GetComponent<UnityEngine.UI.Image>().enabled != true) {

	    	Debug.Log("Delay call");
	    	GameObject.Find("Canvas/touchme").GetComponent<UnityEngine.UI.Text>().enabled = true;

	    }

	}
}
