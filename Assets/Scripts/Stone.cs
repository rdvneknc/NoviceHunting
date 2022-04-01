using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject stone;
    public bool vanishStone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vanishStone = gameObject.transform.position.x > 12;

        if (vanishStone)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.tag == "Bird")
        {


            Destroy(gameObject);


        }


    }
}
