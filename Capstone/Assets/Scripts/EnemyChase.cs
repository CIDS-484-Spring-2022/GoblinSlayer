using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public bool facingRight = true;
    public float speed = 3f;
    private Transform target;
    Collider2D enemyCollider;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Slayer")
        {
            target = other.transform;
        }
        if (other.tag == "Boundary")
        {
            enemyCollider.enabled = true;
        }
    }
    /*
        private void OnTriggerExit2D(Collider2D other) {
            if(other.gameObject.tag == "Slayer"){
                target = null;
            }
        }
    */
    // Start is called before the first frame update
    void Start()
    {
        enemyCollider = GetComponent<Collider2D>();
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
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
        if (target.transform.position.y < gameObject.transform.position.y && !facingRight)
            Flip();
        if (target.transform.position.y > gameObject.transform.position.y && facingRight)
            Flip();

    }
    void Flip()
    {
        //here your flip funktion, as example
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.y *= -1;
        gameObject.transform.localScale = tmpScale;
    }
}
