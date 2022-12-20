using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    Rigidbody rb;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        //  Destroy(gameObject, 3f);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))         // destroys when spacebar selected
        {
            // Destroy(gameObject);

            // rb.AddForce(Vector3.up * 500);
        }
        // rb.velocity = Vector3.forward * 20f;

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level2");
        }
    }
    
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);            // destroys the cube
            Destroy(collision.gameObject);  // destroys the sphere

            winText.SetActive(true);
        }
    }
}
