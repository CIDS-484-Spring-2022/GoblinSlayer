using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed = 3f;
    private Transform target;
    /*
    [SerializeField] private float collideDamage = 5f;
    [SerializeField] private float collideSpeed = .01f;

    private float collide;
    */

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Slayer"){
            target = other.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Slayer"){
            target = null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
/*
    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            if(collideSpeed <= collide){
                other.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-collideDamage);
                collide = 0f;
            }else{
                 collide += Time.deltaTime;
            }
            
        }
    }
 */   
    // Update is called once per frame
    private void Update()
    {
        if(target != null){
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
        

    }
}
