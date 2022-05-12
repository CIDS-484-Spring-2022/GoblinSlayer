using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxCollider : MonoBehaviour
{
    int damage = 1;
    public EnemyHealth enemy;
    Collider2D hitboxCollider;
    // Start is called before the first frame update
    void Start()
    {
        hitboxCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Returns true or false depending on the mouse
        if(Input.GetKeyUp(KeyCode.Mouse0)){
            hitboxCollider.enabled = false;
        }
        
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            hitboxCollider.enabled = true;
        }
    }
    //Deals Damage
    public void DoingDamage(){
        enemy.TakeDamage(damage);
    }
    //When collision occurs it will trigger enemy damage
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy"){                 
            Debug.Log("Enemy took damage");
            enemy.TakeDamage(damage);                                
     }
    }
}
