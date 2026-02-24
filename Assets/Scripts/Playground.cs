using UnityEngine;
using System.Collections.Generic;

public class Playground : MonoBehaviour
{
    public GameObject cube;
    public List <string> names;
    public BV.Range SpawnRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            cube.gameObject.GetComponent<Renderer>().material.color = ColorX.GetRandom();
        
        
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ListX.ShuffleList(names);
            Debug.Log(names[0]);
        }

        
    }
}
