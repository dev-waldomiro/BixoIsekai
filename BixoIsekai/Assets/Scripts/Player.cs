using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    public float moveSpeed = 5f;
    /* private SpriteRenderer r;
    public Sprite poses0;
    public Sprite poses1;
    public Sprite poses2;
    public Sprite poses3;*/

    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        //r = GetComponent<SpriteRenderer>(); 
    }

    void mousePos() {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return;
    }
    
    void Update() {
        faceMouse();
        //spriteChager();
        if(Input.GetMouseButton(0)){
            mousePos();
            direction = (mousePosition - transform.position).normalized;
;           rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        } else {
             rb.velocity = Vector2.zero;
        }
        
    }

    void faceMouse () {
        mousePos();
        direction = new Vector2(mousePosition.x - transform.position.x, 
                                mousePosition.y - transform.position.y
        );
        transform.up = -1*direction;
        return;
    }

    /* void spriteChager() {
        double rotation = transform.rotation.z;
        if(rotation >= -120 && rotation <= 120){
            r.sprite = poses0;
        } else if(rotation < 120 && rotation > 30){
            r.sprite = poses1;
        } else if(rotation <= 30 && rotation >= -30){
            r.sprite = poses2;
        } else if(rotation < -30 && rotation > -120) {
            r.sprite = poses3;
        }
        return;
    }*/

}