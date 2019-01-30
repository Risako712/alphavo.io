using UnityEngine;
using System.Collections;
 
public class TouchScript : MonoBehaviour {
    bool isClicked = false;
    Vector2 currentPoint;
 
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)){
            OnMouseDown();
        }
        if(Input.GetMouseButton(0)){
            OnMouseDrag();
        }
        if(Input.GetMouseButtonUp(0)){
            OnMouseUp();
        }

        transform.Rotate(0,0,10.0f);
        transform.Translate(100.0f, 0,0);
    }
 
    void OnMouseDown(){
        Debug.Log("OnMouseDown");
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
 
        Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
        Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
 
        if(colition2d) {
            RaycastHit2D hitObject = Physics2D.Raycast(tapPoint, -Vector2.up);
            if(hitObject){
                Debug.Log("hit object is " + hitObject.collider.gameObject.name);
                currentPoint = new Vector2(tapPoint.x, tapPoint.y);
                isClicked = true;
            }
        }
    }
 
    void OnMouseDrag(){
        if(!isClicked){
            return;
        }
 
        Debug.Log("OnMouseDrag");
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
 
        Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
        gameObject.transform.position = new Vector2( gameObject.transform.position.x + (tapPoint.x - currentPoint.x), gameObject.transform.position.y + (tapPoint.y - currentPoint.y));
        currentPoint = tapPoint;
    }
 
    void OnMouseUp(){
        isClicked = false;
    }
}