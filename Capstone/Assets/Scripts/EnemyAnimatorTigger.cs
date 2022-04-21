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

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SlayerBoundary")
        {
            animate.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "SlayerBoundary")
        {
            animate.enabled = false;
        }

    }
}
