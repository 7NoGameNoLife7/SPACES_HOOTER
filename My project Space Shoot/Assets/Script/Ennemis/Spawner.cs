using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject prefab;
    public float delai;

    private float prochainTemps;


    private void Update()
    {
        if (Time.time >= prochainTemps)
        {
            Instantiate(prefab, transform.position, transform.rotation);
            prochainTemps = Time.time + delai;
        }
    }
}
