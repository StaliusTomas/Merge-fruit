using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Merge : MonoBehaviour
{
    public GameObject Fruit;
    public GameObject Fruit2;
    public Vector2 location;
    // Start is called before the first frame update
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("1"))
        {
            location = other.transform.position;
            Destroy(other.gameObject);
            Instantiate(Fruit2, location, Quaternion.identity);
        }
    }
}
