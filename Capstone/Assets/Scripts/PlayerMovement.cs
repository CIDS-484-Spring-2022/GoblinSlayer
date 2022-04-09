using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float moveSpeed = 7f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveHorizontal, moveVertical, 0);

        Vector3 characterScale = transform.localScale;
        /*
        if (Input.GetKey(KeyCode.A)){
            GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, -90);
        }
        if (Input.GetKey(KeyCode.D)){
            GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 90);
        }
        if (Input.GetKey(KeyCode.W)){
            GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 180);
        }
        if (Input.GetKey(KeyCode.S)){
            GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 0);
        }
        */

        // Character flips on x-axis
        if(Input.GetAxis("Horizontal") < 0 ){
            /*
            Transform transform = GetComponent<Transform>();
            transform.Rotate( new Vector3(0, 0, 90));
            */
            //GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, -90);
            characterScale.x = -3;
            
        }
        if(Input.GetAxis("Horizontal") > 0 ){
            characterScale.x = 3;
            //GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 90);
        }
        
        //Character flips on y-axis
        if(Input.GetAxis("Vertical") < 0 ){
            characterScale.y = 3;
            //GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 180);
        }
        
        if(Input.GetAxis("Vertical") > 0 ){
            characterScale.y = -3;
            //GetComponent<Transform>().eulerAngles = new Vector3 (0, 0, 0);
        }
        
        transform.localScale = characterScale;
        

    }

}
