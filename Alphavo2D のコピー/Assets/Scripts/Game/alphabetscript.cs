using UnityEngine;
using System.Collections;

public class alphabetscript : MonoBehaviour {

 private Vector3 screenPoint;
    private Vector3 offset;
    private bool isDrag = false;
    private bool isWalk = true;
    private bool isThrow = false;
    private Vector3 prevPoint;
    private Vector3 nowPoint;
    private float dragDeltaTime = 0f;
    private float walkSpeed;
 
    public float forceScale;
    public float walkSpeedMin;
    public float walkSpeedMax;

    public float posx, posy, posz;

    public float forceX;
    public float forceY;


 
    // Use this for initialization
    void Awake () 
    {
    	posx = -0.3f;
    	posy = Random.value * 3f;
    	posz = 0;
        walkSpeed = (Random.value * (walkSpeedMax - walkSpeedMin)) + walkSpeedMin;
        transform.position = new Vector3 (posx, posy, posz); 
    }
     
    // Update is called once per frame
    void Update () 
    {
        if (isDrag) 
        {
            prevPoint = nowPoint;
            nowPoint = transform.position;
            dragDeltaTime = Time.deltaTime;
        }
        if(isWalk)
        {
            transform.position += new Vector3(walkSpeed * Time.deltaTime, 0, 0);
        }

        // if (transform.position.x > 1000){

        //     transform.Translate(-100, 0,0);
        // }

        // if (transform.position.x < -793){

        //     transform.Translate(100, 0,0);

        // }


        //  if (transform.position.y > -1){

        //     transform.Translate(0, -100,0);

        // }

        // if (transform.position.y < -900){

        //     transform.Translate(0, 100,0);

        // }




        //Debug.Log("Risako nowpoint:" + transform.position);


    }
 
    void OnMouseDown() 
    {
        nowPoint = transform.position;
        isThrow = false;
        isDrag = true;
        isWalk = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        nowPoint = transform.position;
    }
 
    void OnMouseDrag() 
    {
        if (!isThrow) 
        {
            Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
            transform.position = currentPosition;
            if(currentScreenPoint.y  > (Screen.height / 2))
            {
                Throwing();
            }
        }
    }
 
    void OnMouseUp() 
    {
        Throwing ();
    }

    void Throwing()
    {
        if (!isThrow) 
        {
            //Debug.Log ("prevPoint:" + prevPoint + " nowPoint:" + nowPoint + " dragDeltaTime:" + dragDeltaTime);
            float forceX = (nowPoint.x - prevPoint.x) / dragDeltaTime;
            forceY = (nowPoint.y - prevPoint.y) / dragDeltaTime;
            GetComponent<Rigidbody2D>().AddForce (new Vector2 (forceX, forceY) * forceScale);
            //Debug.Log ("AddForce:" + (new Vector2 (forceX, forceY) * forceScale));
            //isDrag = false;
            isThrow = true;
        }
    }
}