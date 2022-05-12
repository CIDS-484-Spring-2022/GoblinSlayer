using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOver : MonoBehaviour
{
    //Game Over Screen. Loops to the Menu Scene
    public void LoadGame(){
        SceneManager.LoadScene("Menu");
    }
}
