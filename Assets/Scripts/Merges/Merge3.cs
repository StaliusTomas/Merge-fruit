using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fruit3;
    public GameObject Fruit4;
    Vector2 location;
    // Start is called before the first frame update
    private void OnCollision2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("3"))
        {
            location = other.transform.position;
            Destroy(other.gameObject);
            Destroy(Fruit3);
            Instantiate(Fruit4, location, Quaternion.identity);
        }
    }
}
