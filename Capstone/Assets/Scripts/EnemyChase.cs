using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public bool facingRight = true;
    public float speed = 3f;
    private Transform target;
    Collider2D enemyCollider;

    //Enables collider when hit 
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
    
    // Start is called before the first frame update
    void Start()
    {
        enemyCollider = GetComponent<Collider2D>();
    }
    
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
        //Flips the enemy direction
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.y *= -1;
        gameObject.transform.localScale = tmpScale;
    }
}
