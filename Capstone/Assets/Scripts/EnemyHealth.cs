using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHeath;
    // Start is called before the first frame update
    void start()
    {
        currentHeath = maxHealth;
    }
    //Deals damage
    public void TakeDamage(int damage)
    {
        currentHeath -= damage;
        if (currentHeath <= 0)
        {
            //Debug.Log("Dead");
            Destroy(gameObject);
        }
    }

}
