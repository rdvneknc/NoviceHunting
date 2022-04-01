using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birds : MonoBehaviour
{
    public float spawnTime = 3f;
    public float spawnDelay = 2f;
   public GameObject eagle;
    
    public float speed;

    public Text scoreText;

    public Rigidbody2D rb;
    public bool original = false;
    public GameObject soundGO;
    public bool dead = false;

    

  
    


    void Start()
    {



        

       


    }
   

    private void Update()
    {
        bool burnThem = gameObject.transform.position.y < -7;

        if (dead)
        {
            return;
        }
        
        bool killThem = gameObject.transform.position.x < -15;


        if (original)
        {
            return;
        }

        if (killThem)
        {
            Destroy(gameObject);
        }


        transform.position += -transform.right * speed * Time.deltaTime  ;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        soundGO = GameObject.Find("VoiceKeeper");

        if (other.gameObject.tag == "Stone")
        {

            //eagle.transform.Rotate(0, 0, 80);

            soundGO.GetComponent<Voice>().VoiceFunction();

            GetComponent<Rigidbody2D>().isKinematic = false;

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            

            dead = true;


            //Destroy(gameObject);
            
            
        }


    }

 

    
      

   


}
