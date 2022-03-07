using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool getWeapon;
    public GameObject weaponSprite;

    [SerializeField] float moveSpeed = 7f;
    void Start()
    {
        getWeapon = false;
        weaponSprite.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveHorizontal, moveVertical, 0);

        if (getWeapon == true)
        {
            weaponSprite.SetActive(true);
        }
    }

}
