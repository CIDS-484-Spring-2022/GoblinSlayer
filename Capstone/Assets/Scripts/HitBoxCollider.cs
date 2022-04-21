using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxCollider : MonoBehaviour
{
    Collider2D hitboxCollider;
    // Start is called before the first frame update
    void Start()
    {
        hitboxCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0)){
            hitboxCollider.enabled = false;
        }
        

        if(Input.GetKeyDown(KeyCode.Mouse0)){
            hitboxCollider.enabled = true;
        }
    }
}
