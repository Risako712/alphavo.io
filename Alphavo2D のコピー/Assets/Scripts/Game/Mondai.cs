using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mondai : MonoBehaviour {

	public int startflg = 1;

	public GameObject[] Kotae;

	public GameObject[] Q;

	public GameObject Seikai;

	public int number;

	public int count = 26;

	public int timeflg = 0;


	private AudioSource voicesan;
	public AudioClip pinpon;
	public AudioClip pipi;

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
	
	}
	
	// Update is called once per frame
	void Update () {

		//タイマー
		if (timeflg == 0) {
			GameObject.Find("TIMER").GetComponent<Text>().text = ((int)Time.time).ToString ();
		}

		
	}



	public void NormalModeStart () {

		startflg = 1;

	}

	public void HardModeStart() {

	}

	public void EasyMode () {


		if (count != 0){
			number = Random.Range(27,53);

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
			timeflg = 1;
		}





	}

	void OnTriggerEnter2D (Collider2D other){

		//Debug.Log("butukatta");

		if (other.gameObject == Kotae[number-26]){

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

	void saikoro () {
		number = Random.Range(1,27);
		EasyMode();

	}









	//音クラス

	public void ButtonClicked() {

		if(number == 27){
			a_voice();
		}
		if(number == 28){
			b_voice();
		}
		if(number == 29){
			c_voice();
		}
		if(number == 30){
			d_voice();
		}
		if(number == 31){
			e_voice();
		}
		if(number == 32){
			f_voice();
		}
		if(number == 33){
			g_voice();
		}
		if(number == 34){
			h_voice();
		}
		if(number == 35){
			i_voice();
		}
		if(number == 36){
			j_voice();
		}
		if(number == 37){
			k_voice();
		}
		if(number == 38){
			l_voice();
		}
		if(number == 39){
			m_voice();
		}
		if(number == 40){
			n_voice();
		}
		if(number == 41){
			o_voice();
		}
		if(number == 42){
			p_voice();
		}
		if(number == 43){
			q_voice();
		}
		if(number == 44){
			r_voice();
		}
		if(number == 45){
			s_voice();
		}
		if(number == 46){
			t_voice();
		}
		if(number == 47){
			u_voice();
		}
		if(number == 48){
			v_voice();
		}
		if(number == 49){
			w_voice();
		}
		if(number == 50){
			x_voice();
		}
		if(number == 51){
			y_voice();
		}
		if(number == 52){
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
