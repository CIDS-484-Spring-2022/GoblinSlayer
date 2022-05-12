using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorTigger : MonoBehaviour
{
    Animator animate;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Starts the enemy animation  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SlayerBoundary")
        {
            animate.enabled = true;
        }
    }
    //Turns animation off when not in boundary
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "SlayerBoundary")
        {
            animate.enabled = false;
        }

    }
}
