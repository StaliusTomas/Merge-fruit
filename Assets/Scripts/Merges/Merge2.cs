using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fruit2;
    public GameObject Fruit3;
    Vector2 location;
    // Start is called before the first frame update
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("2"))
        {
            location = other.transform.position;
            Destroy(other.gameObject);
            Destroy(Fruit2);
            Instantiate(Fruit2, location, Quaternion.identity);
        }
    }
}
