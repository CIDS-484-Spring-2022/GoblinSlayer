using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    public PlayerMovement move_script;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Slayer")
        {
            Debug.Log("Picked up Rusty Sword!");
            move_script.getWeapon = true;

            rend = GetComponent<Renderer>();
            rend.enabled = true;
        }
    }
}