using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //public attributes
    public GameObject DiedEffect;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move to right
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f*Time.deltaTime,0));
        }
        //move to left
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f*Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));

        }

        if (Input.GetKeyDown("space"))
        {
            Instantiate(bala, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            Destroy(bala, 4f);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "walls")
        {
            Instantiate(DiedEffect, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), transform.rotation);
            Destroy(this.gameObject);
            GameOver.show();   
        }
    }
}
