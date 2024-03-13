using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merge5 : MonoBehaviour
{
    public bool isMerging;
    public GameObject Fruit2;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("5")) return;
        if (isMerging) return;
        other.gameObject.GetComponent<Merge5>().isMerging = true;

        Destroy(other.gameObject);
        Destroy(gameObject);
        other.collider.enabled = false;

        Instantiate(Fruit2, transform.position, Quaternion.identity);
    }
}
