using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {

    private PlayerController Player;

    // Start is called before the first frame update
    void Start() {
        Player = GetComponentInParent<PlayerController>();
    }

    void OnCollisionStay2D(Collision2D col){
        if(col.gameObject.tag == "Ground"){
            Player._isGrounded = true;
        }
        if (col.gameObject.tag == "Platform"){
            Player.transform.parent = col.transform;
            Player._isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col){
        if (col.gameObject.tag == "Ground"){
            Player._isGrounded = false;
        }
        if (col.gameObject.tag == "Platform"){
            Player.transform.parent = null;
            Player._isGrounded = false;
        }
    }
}
