using UnityEngine;
using System.Collections;

public class StudyOtotsuke : MonoBehaviour {

	private AudioSource univoice;

	public AudioClip cha;
	public AudioClip conga;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cha_audio (){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(cha);
	}
	public void conga_audio (){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(conga);
	}


	public void backbutton () {

		Application.LoadLevel(0);

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(conga);
	}

	public void Gamemodeback () {

		Application.LoadLevel(3);

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(conga);
	}

	public void ToStudyMode (){

		Application.LoadLevel(2);
	}

}
