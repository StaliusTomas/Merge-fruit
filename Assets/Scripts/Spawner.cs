using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Fruit;
    public GameObject Fruit2;
    public Vector2 MousePos;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MousePos.y = 4f;
            SpawnFruit();
        }

    }
    void SpawnFruit()
    {
        int rnd = UnityEngine.Random.Range(0, 10);
        if (rnd  < 7) 
        {
            Instantiate(Fruit, MousePos, Quaternion.identity);
        }

        else if (rnd >= 7)
        {
            Instantiate(Fruit2, MousePos, Quaternion.identity);
        }

    }
}
