using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelAdvance : MonoBehaviour
{
    public int levelToLoad = 1;
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            print("Collision detected");
            SceneManager.LoadScene("Level" + levelToLoad);
        }
    }
}
