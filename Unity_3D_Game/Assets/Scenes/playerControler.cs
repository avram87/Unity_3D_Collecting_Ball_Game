using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerControler : MonoBehaviour {

    Rigidbody rb;
    float speed = 50f;
   
    public Text txtScore;
    int Score;

    public GameObject panelGameOver;

    bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
  
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
            Score++;
            txtScore.text = "Score :" + Score;
        }
        
        if (other.gameObject.tag == "enemy")
        {
            isGameOver = true;
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            panelGameOver.SetActive(true);
 
        }
    } 
    public void playAgainUI()
    {
        SceneManager.LoadScene("sceneOne");
    }
}
