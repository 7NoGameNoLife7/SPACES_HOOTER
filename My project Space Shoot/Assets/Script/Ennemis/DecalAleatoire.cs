using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalAleatoire : MonoBehaviour
{
    public float magnitude = 1f;

    private Vector2 positionDeBase;

    private void Start()
    {
        positionDeBase = transform.position;
    }

    void Update()
    {
        float decalage = Random.Range(-magnitude, magnitude);
        transform.position = positionDeBase + Vector2.right * decalage;
    }
}
