﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mondaieasy : MonoBehaviour {

	public int startflg = 1;

	public GameObject[] Kotae;

	public GameObject[] Q;

	public GameObject Seikai;

	public int number;

	public int count = 26;

	public int timeflg = 0;

	public int score2;

	public static int highScore2;

	private string highScoreKey2 = "highScore2";


	public AudioSource voicesan;
	public AudioClip pinpon;
	public AudioClip pipi;

	public AudioSource back;
	public AudioClip back1;
	public AudioClip back2;


	//音たち
	public AudioSource univoice;
	public AudioClip a;
	public AudioClip b;
	public AudioClip c;
	public AudioClip d;
	public AudioClip e;
	public AudioClip f;
	public AudioClip g;
	public AudioClip h;
	public AudioClip i;
	public AudioClip j;
	public AudioClip k;
	public AudioClip l;
	public AudioClip m;
	public AudioClip n;
	public AudioClip o;
	public AudioClip p;
	public AudioClip q;
	public AudioClip r;
	public AudioClip s;
	public AudioClip t;
	public AudioClip u;
	public AudioClip v;
	public AudioClip w;
	public AudioClip x;
	public AudioClip y;
	public AudioClip z;


	private float TimeNow = 0.0f;


	// Use this for initialization


	void Start () {


		//スタート時に全ての問題を非表示
		int i;

		// for(i = 1; i < 53; i++) {
		// 	//GameObject.
		// 	Q[i].GetComponent<UnityEngine.UI.Image>().enabled = false;
		// }

		EasyMode ();

		GetComponent<Renderer>().material.color = new Color(1f, 0.82f, 0.4f, 1.0f);

		GameObject.Find("SCORE").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.Find("HISCORE").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.Find("COMMENT").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.Find("COMMENT2").GetComponent<UnityEngine.UI.Text>().enabled = false;

		back = GetComponent<AudioSource>();
		back.PlayOneShot(back1);

		Initialize ();
	
	}
	
	// Update is called once per frame
	void Update () {

		TimeNow += Time.deltaTime;

		//タイマー
		if (timeflg == 0) {
			GameObject.Find("TIMER").GetComponent<Text>().text = ((int)TimeNow).ToString ();
			score2 = (int)TimeNow;		
		}

		//TimeNow += Time.deltaTime;
		
	}



	public void NormalModeStart () {

		startflg = 1;

	}


	public void EasyMode () {


		if (count != 0){
			number = Random.Range(1,27);

			if(Q[number] != null) {
				Debug.Log(Q[number]);
				Q[number].GetComponent<UnityEngine.UI.Image>().enabled = true;
			}
			else {
				saikoro();
			}

		}

		if (count == 0){  //ゲーム終了

			Debug.Log("omedeto");
			voicesan.GetComponent<AudioSource>();
			voicesan.PlayOneShot(pipi);


			Invoke("DelayMethod_3", 1.5f);

			timeflg = 1;

			GameObject.Find("SCORE").GetComponent<UnityEngine.UI.Text>().enabled = true;

           if (highScore2 > score2) {
                    highScore2 = score2;
                    GameObject.Find("COMMENT2").GetComponent<UnityEngine.UI.Text>().enabled = true;
            }



            // スコア・ハイスコアを表示する
			GameObject.Find("SCORE").GetComponent<UnityEngine.UI.Text>().text = score2.ToString();
            GameObject.Find("HISCORE").GetComponent<UnityEngine.UI.Text>().text = highScore2.ToString();


			GameObject.Find("SCORE").GetComponent<UnityEngine.UI.Text>().enabled = true;
			GameObject.Find("HISCORE").GetComponent<UnityEngine.UI.Text>().enabled = true;
			GameObject.Find("COMMENT").GetComponent<UnityEngine.UI.Text>().enabled = true;

            Save();





		}





	}

	void OnTriggerEnter2D (Collider2D other){

		//Debug.Log("butukatta");

		if (other.gameObject == Kotae[number]){

			Seikai = other.gameObject;

			Invoke("DelayMethod", 0.5f);
				
			Debug.Log(Seikai);

			GetComponent<Renderer>().material.color = new Color(0.3f, 0.4f, 1.0f, 1.0f);
			Invoke("DelayMethod_2", 0.5f);

			voicesan = GetComponent<AudioSource>();
			voicesan.PlayOneShot(pinpon);

			Destroy(Q[number]);
			Q[number] = null;
			count -= 1;
			EasyMode();






		}
	}


	void DelayMethod() {
	    Destroy(Seikai);
	}

	void DelayMethod_2() {
		GetComponent<Renderer>().material.color = new Color(1f, 0.82f, 0.4f, 1.0f);
	}

	void DelayMethod_3() {

		back = GetComponent<AudioSource>();
		back.Stop();

		back = GetComponent<AudioSource>();
		back.PlayOneShot(back2);
	}

	void saikoro () {
		number = Random.Range(1,27);
		EasyMode();

	}

   private void Initialize ()
    {
        // スコアを0に戻す
        score2 = 0;

 		// ハイスコアの初期設定
		if (PlayerPrefs.GetInt("highScore2") == 0){
			PlayerPrefs.SetInt("highScore2", 120);
		}
		else {
			highScore2 = PlayerPrefs.GetInt("highScore2");
		}
    }


    //ハイスコアの保存
    public void Save ()
    {
        // ハイスコアを保存する
        PlayerPrefs.SetInt ("highScore2", highScore2);
        PlayerPrefs.Save();



        // ゲーム開始前の状態に戻す
        Initialize ();
    }









	//音クラス

	public void ButtonClicked() {

		if(number == 1){
			a_voice();
		}
		if(number == 2){
			b_voice();
		}
		if(number == 3){
			c_voice();
		}
		if(number == 4){
			d_voice();
		}
		if(number == 5){
			e_voice();
		}
		if(number == 6){
			f_voice();
		}
		if(number == 7){
			g_voice();
		}
		if(number == 8){
			h_voice();
		}
		if(number == 9){
			i_voice();
		}
		if(number == 10){
			j_voice();
		}
		if(number == 11){
			k_voice();
		}
		if(number == 12){
			l_voice();
		}
		if(number == 13){
			m_voice();
		}
		if(number == 14){
			n_voice();
		}
		if(number == 15){
			o_voice();
		}
		if(number == 16){
			p_voice();
		}
		if(number == 17){
			q_voice();
		}
		if(number == 18){
			r_voice();
		}
		if(number == 19){
			s_voice();
		}
		if(number == 20){
			t_voice();
		}
		if(number == 21){
			u_voice();
		}
		if(number == 22){
			v_voice();
		}
		if(number == 23){
			w_voice();
		}
		if(number == 24){
			x_voice();
		}
		if(number == 25){
			y_voice();
		}
		if(number == 26){
			z_voice();
		}





	}


	public void a_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(a);
	}
	
	public void b_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(b);
	}	

	public void c_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(c);
	}	
	public void d_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(d);
	}	
	public void e_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(e);
	}	
	public void f_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(f);
	}	
	public void g_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(g);
	}	
	public void h_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(h);
	}	
	public void i_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(i);
	}	
	public void j_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(j);
	}	
	public void k_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(k);
	}	
	public void l_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(l);
	}	
	public void m_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(m);
	}	
	public void n_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(n);
	}	
	public void o_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(o);
	}	
	public void p_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(p);
	}	

	public void q_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(q);
	}	
	public void r_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(r);
	}	
	public void s_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(s);
	}	
	public void t_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(t);
	}	
	public void u_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(u);
	}	
	public void v_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(v);
	}	
	public void w_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(w);
	}	
	public void x_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(x);
	}	
	public void y_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(y);
	}	

	public void z_voice(){

		univoice = GetComponent<AudioSource>();
		univoice.PlayOneShot(z);
	}	

}