﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

   /*  private float timeBtwAttack = 11;
    public float startTimeBtwAttack = 10;
    
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    
    public int damage;

    public Animator playerAni;

     void Update() {
        if (timeBtwAttack <= 0){
            if(Input.GetMouseButton(1)){
                playerAni.SetTrigger("attack");
                
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for(int i = 0; i < enemiesToDamage.Length; i++ ){
                    enemiesToDamage[i].GetComponent<Enemy>().health -=damage;
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        
        } else {
            timeBtwAttack -= Time.deltaTime;
        }
    }  

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }*/
}
