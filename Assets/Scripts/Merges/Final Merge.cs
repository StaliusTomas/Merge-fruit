using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMerge : MonoBehaviour
{
    public bool isMerging;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("7")) return;
        if (isMerging) return;
        other.gameObject.GetComponent<FinalMerge>().isMerging = true;

        Destroy(other.gameObject);
        Destroy(gameObject);
        other.collider.enabled = false;

        SceneManager.LoadScene("Win");
    }
}
