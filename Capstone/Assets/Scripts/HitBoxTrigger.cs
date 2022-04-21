using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxTrigger : MonoBehaviour
{
    [SerializeField] private int attackDamage = 10;
    Collider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SlayerBoundary")
        {
            boxCollider.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "SlayerBoundary")
        {
            boxCollider.enabled = false;
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Slayer")
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
    }
}
