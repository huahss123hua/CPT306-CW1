using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> Ionisedcreater = new List<GameObject>();

    public float spawnTime;
    private float countTime;
    private Vector2 spwanPosition;

    public static int barrier;
    public static int red;
    public static int green;
    public static int blue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    public void Spawn()
    {
        countTime += Time.deltaTime;
        spwanPosition = transform.position;
        
        if(countTime >= spawnTime)
        {
            CreateObject();
            countTime = 0;
        }
    }

    public void CreateObject()
    {
        int index = Random.Range(0, Ionisedcreater.Count);

        Instantiate(Ionisedcreater[index], spwanPosition, Quaternion.identity);

        if(index == 0)
        {
            barrier += 1;
        }
        else if(index == 1)
        {
            red++;
        }
        else if(index == 2)
        {
            green++;
        }
        else if(index == 3)
        {
            blue++;
        }
    }
}
