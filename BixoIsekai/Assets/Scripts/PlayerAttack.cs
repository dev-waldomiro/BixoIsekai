using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public float attackRange;
    public int damage;

    // private Collider2D[] enemiesToDamage;
    public Transform attackPos;
    public LayerMask whatIsEnemie;
    public Animator animator;

    void Update() {
        if(timeBtwAttack <= 0){

            if(Input.GetMouseButton(1)){
                animator.SetBool("attacking", true);
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemie);
                for (int i = 0; i < enemiesToDamage.Length; i++) {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                timeBtwAttack = startTimeBtwAttack;
            } 
        } else {
            animator.SetBool("attacking", false);
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected(){

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
