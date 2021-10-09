using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GitHub Co-Pilot plz fix

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    //somebody once told me i can code now so cool beans
    private Vector2 direction;
    public float speed = 420.0f;
    public float reviewScores = (new System.Random()).Next();
    public float jumpForce = 69.0f; // My favorite Goku video game
    public float gravity = -30.0f;

    public GameObject prefab;
    // kill
    // Update is called once per frame

    void Update()
    {
        float hInput = -Input.GetAxis("Vertical");
        direction.x = hInput * speed; //x axis movement

        direction.y -= gravity * Time.deltaTime; //garaavity

        bool onGround = false;
        if (onGround) // if on the ground, and if w is pressed, jump.
        {
            if (Input.GetKeyDown("w")) //jump
            {
                direction.x = jumpForce * reviewScores;
            }
        }

        if (Input.GetKeyDown("p"))
        {
            Destroy(this.gameObject.transform.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravity = 30.0f;
        }
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(1.0f, 255.0f) / 255.0f, Random.Range(1.0f, 255.0f) / 255.0f, Random.Range(1.0f, 255.0f) / 255.0f);

        if (Input.anyKey)
        {
            GetComponent<Rigidbody2D>().AddForce(direction * 7.0f);

           // this.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(1000f, 500f, 100f);
        }
    }

    void FrickYou(Vector3 FrickPosition)
    {
        Instantiate(prefab, FrickPosition, Quaternion.identity);
    }
}


