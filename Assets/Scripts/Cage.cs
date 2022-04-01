using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : MonoBehaviour
{
    public GameObject eagle;
    public Vector2 position;


    private void Start()
    {
        InvokeRepeating("Spawn", 1, 1);

       
    }


    void Spawn()
    {
       
        int enemyIndex = Random.Range(0, 0);

       
        GameObject copyBird = Instantiate(eagle, position, transform.rotation);

        float number = Random.Range(-4, 5);

        copyBird.transform.position = new Vector3(13, number, 0);

        copyBird.GetComponent<Birds>().original = false;

        copyBird.name = "Poor Bird";

        



    }
}
