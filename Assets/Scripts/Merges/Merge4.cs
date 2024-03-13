using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fruit4;
    public GameObject Fruit5;
    Vector2 location;
    // Start is called before the first frame update
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("4"))
        {
            location = other.transform.position;
            Destroy(other.gameObject);
            Destroy(Fruit4);
            Instantiate(Fruit5, location, Quaternion.identity);
        }
    }
}
