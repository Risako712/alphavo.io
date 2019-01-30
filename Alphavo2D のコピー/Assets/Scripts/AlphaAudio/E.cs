using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class E : MonoBehaviour {

	private AudioSource univoice;

	public AudioClip voice_E;
	public AudioClip voice_elephant;

	public void Evoice () {

		univoice = GetComponent<AudioSource> ();
		univoice.PlayOneShot(voice_E);
		Debug.Log("aaa");

	}

	public void Elephantvoice () {

		univoice = GetComponent<AudioSource> ();
		univoice.PlayOneShot(voice_elephant);
		Debug.Log("aaa");

	}
}
