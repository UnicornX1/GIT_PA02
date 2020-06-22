using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject tire;
    public GameObject IceBlock;
    public GameObject Barrel;
    public GameObject Walrus;

    public float spawnRate = 5f;

    float nextSpawn;

    int WhatToSpawn;

    float SpawnLocation;

    float PositionX;

    bool Gamestart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            Gamestart = true;
        }
        if (Gamestart == true)
        {
            if (Time.time > nextSpawn)
            {
                WhatToSpawn = Random.Range(1, 5);
                //print(WhatToSpawn);
                nextSpawn = Time.time + spawnRate;
                switch (WhatToSpawn)
                {
                    case 1:
                        PositionX = Random.Range(-6, 6f);
                        this.transform.position = new Vector3(PositionX, 0, 0);
                        Instantiate(tire, transform.position, transform.rotation);
                        break;

                    case 2:
                        PositionX = Random.Range(-6, 6f);
                        this.transform.position = new Vector3(PositionX, 0, 0);
                        Instantiate(Barrel, transform.position, transform.rotation);
                        break;

                    case 3:
                        PositionX = Random.Range(-6, 6f);
                        this.transform.position = new Vector3(PositionX, 0, 0);
                        Instantiate(Walrus, transform.position, transform.rotation);
                        break;

                    case 4:
                        PositionX = Random.Range(-6, 6f);
                        this.transform.position = new Vector3(PositionX,0,0);
                        Instantiate(IceBlock, transform.position, transform.rotation);
                        break;
                }
            }
        }
    }
}
