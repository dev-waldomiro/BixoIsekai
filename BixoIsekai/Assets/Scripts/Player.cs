using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int hp = 100;

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
        Debug.Log(rb.velocity);
        } else {
             rb.velocity = Vector2.zero;
        }

        //Teste do Personagem recebendo dano
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Ai!");
            this.Dano(50);
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

    public void Dano(int dano)
    {
        hp -= dano;
        if (hp <= 0)
        {
            Debug.Log("Bixo morreu. Retornando ao menu inicial.");
            SceneManager.LoadScene("MenuInicial");
        }
    }

}