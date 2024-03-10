using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Merge : MonoBehaviour
{
    public GameObject Fruit;
    public GameObject Fruit2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject == Fruit)
        {
            Destroy(other.gameObject);
            Destroy(Fruit);
            Instantiate(Fruit2);
        }
    }
}
