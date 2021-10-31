using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour
{
    public int speed = 10;
    Rigidbody rb;
    bool isAlive = true;
    int score = 0;
    public Text score_ui;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
    }

    void FixedUpdate()
    {
        if (!isAlive){
            return;
        }
        float zSpeed = Input.GetAxis("Vertical");
        float xSpeed = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector3(xSpeed, 0, zSpeed));

        if (transform.position.y < -10){
            isAlive = false;
            SceneManager.LoadScene("Level1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) 
        {
            other.gameObject.SetActive(false);
            score++;
            SetCountText();

        }
    }

    void SetCountText()
    {
        score_ui.text = "Count: " + score.ToString();
        // if (count >= 10)
        // {
        //     winText.text = "You Win!";
        // }
    }

    
}
