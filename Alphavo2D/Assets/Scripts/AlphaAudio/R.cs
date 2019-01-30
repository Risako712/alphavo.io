using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class R : MonoBehaviour {


	private AudioSource univoice;

	public AudioClip voice_R;
	public AudioClip voice_rainbow;

	public void Rvoice () {

		univoice = GetComponent<AudioSource> ();
		univoice.PlayOneShot(voice_R);
		Debug.Log("aaa");

	}

	public void Rainbowvoice () {

		univoice = GetComponent<AudioSource> ();
		univoice.PlayOneShot(voice_rainbow);
		Debug.Log("aaa");

	}
}
