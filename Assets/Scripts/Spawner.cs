using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Fruit;
    public GameObject Fruit2;
    Vector2 Hover = new Vector2(0, 4);
    float MouseX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnFruit),0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = Input.mousePosition.x;
    }
    void SpawnFruit()
    {
        int rnd = UnityEngine.Random.Range(0, 10);
        if (rnd  < 7) 
        {
            Instantiate(Fruit, Hover, Quaternion.identity);
            Fruit.GetComponent<Rigidbody2D>().isKinematic = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Fruit.GetComponent<Rigidbody2D>().isKinematic = true;
                Fruit.transform.position = new Vector2(MouseX, 4);
            }
            else
            {
                Fruit.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }

        else if (rnd >= 7)
        {
            Instantiate(Fruit2, Hover, Quaternion.identity);
            Fruit2.GetComponent<Rigidbody2D>().isKinematic = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Fruit2.GetComponent<Rigidbody2D>().isKinematic = true;
                Fruit2.transform.position = new Vector2(MouseX, 4);
            }
            else
            {
                Fruit.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }

    }
}
