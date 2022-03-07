using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   
    [SerializeField] float destroyWeapon = .01f;
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ack!");
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Rusty Sword"){
            Destroy(other.gameObject, destroyWeapon);
        }   
    }
}
