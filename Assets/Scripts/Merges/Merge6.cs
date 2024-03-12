using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge6 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fruit6;
    public GameObject Fruit7;
    Vector2 location;
    // Start is called before the first frame update
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("6"))
        {
            location = other.transform.position;
            Destroy(other.gameObject);
            Destroy(Fruit6);
            Instantiate(Fruit7, location, Quaternion.identity);
        }
    }
}
