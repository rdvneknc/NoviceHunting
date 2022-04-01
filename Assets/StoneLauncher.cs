using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneLauncher : MonoBehaviour
{
    public GameObject stone;
    public Vector2 position;
    private Rigidbody2D rb;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        position = new Vector2(-6.88f, -5.47f);

        //rb.velocity = new Vector2(-3.25f, -0.4049648f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(3.25f, -0.4049648f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject killerStone = Instantiate(stone, position, transform.rotation);



            rb = killerStone.GetComponent<Rigidbody2D>();

            rb.isKinematic = false;

            rb.AddForce(transform.up * 800);

            rb.AddForce(transform.right * 800);



            //rb.velocity = new Vector2(-3.25f, -0.4049648f);

            


        }


    }

    

        // void Spawn()

    
}
