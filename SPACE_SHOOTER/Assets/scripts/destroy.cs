using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public string target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == target)
        {
            Destroy(other.gameObject);
        }
    }
}
