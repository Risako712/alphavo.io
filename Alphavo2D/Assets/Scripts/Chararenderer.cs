using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SmoothMoves;

public class Chararenderer : MonoBehaviour {

	BoneAnimation boneAnime = null;

	private AudioSource univoice;

	public AudioClip chara;

	// SEチャンネル数
	// const int SE_CHANNEL = 4;



	public int flg = 3;

	// enum eType {
	//     Bgm, // BGM
	//     Se,  // SE
 // 	}

	// Use this for initialization
	void Start () {

		GetComponent<Renderer>().enabled = false;
		Debug.Log("aa");

		boneAnime = GetComponent<BoneAnimation>();

		if(GameObject.FindWithTag("PreviousUI") != null) {
			GameObject.FindWithTag("PreviousUI").tag = ("AstandbyUI");
		}
	
	}
	
	// Update is called once per frame
	void Update () {



			if (Input.GetMouseButtonDown (0)) {
		        Vector2 tapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		        Collider2D collider = Physics2D.OverlapPoint (tapPoint);

		        if (collider != null) {
		            GameObject obj = collider.transform.gameObject;

	        		if (boneAnime != null && Random.value > 0.3f) {
	            		boneAnime.Play("Idle");

	            		// flg = 1;
	            		// Debug.Log("flg = 1");


	     //        		if (flg == 1) {

						// 	Debug.Log("uketotta");
						// 	univoice = GetComponent<AudioSource>();
						// 	univoice.PlayOneShot(chara);
							
						// 	flg = 2;

						// }


	            		//boneAnime = null;
	            		}
		        	}
		        }
	       
	    }






	public void ButtonClicked () {

		boneAnime.Stop("Idle");


		GameObject.FindWithTag("PreviousChara").GetComponent<Renderer>().enabled = false;
		GameObject.FindWithTag("PreviousChara").tag = ("AstandbyChara");
		this.tag = ("PreviousChara");
	

		GetComponent<Renderer>().enabled = true;

		flg = 0;

		//Debug.Log("kitayo");
	}

	public void chara_audio (){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(chara);
	}

  /// 破棄
 	//  public void charachara() {
  //   // やられSE再生
  //   	Sound.PlaySe("chara", 0);
 	//  }

	 // public void Sound() {
	 //    // チャンネル確保
	 //    _sourceSeArray = new AudioSource[SE_CHANNEL];
	 //  }

}
