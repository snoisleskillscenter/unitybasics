using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniControl : MonoBehaviour {

    public float ctlSpeed;
    Animator ani;
    Vector3 v3;
    float scaleX;
    bool jumpState = false;

	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
        v3 = transform.localScale;
        scaleX = v3.x;
        Debug.Log(scaleX);
	}
	
	// Update is called once per frame
	void Update () {
        
        ctlSpeed = Input.GetAxis("Horizontal");
        ani.SetFloat("aniCtlSpeed", ctlSpeed);
        if (ctlSpeed > 0) v3.x = -scaleX;
        if (ctlSpeed < 0) v3.x = scaleX;
      
        if (Input.GetKeyDown("space"))
        {
            jumpState = !jumpState;
            
            ani.SetBool("aniJump", jumpState);
            if (jumpState)
            {
                //v3.y = -1;
               
            } else
            {
                v3.y = 1;
            }
        }
        transform.localScale = v3;


    }
}
