using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fruit5;
    public GameObject Fruit6;
    Vector2 location;
    // Start is called before the first frame update
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("5"))
        {
            location = other.transform.position;
            Destroy(other.gameObject);
            Destroy(Fruit5);
            Instantiate(Fruit6, location, Quaternion.identity);
        }
    }
}
