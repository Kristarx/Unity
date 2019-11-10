using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnScript : MonoBehaviour
{
    float spawnThreshold = 100;
    float spawnDecrement = .1f;

    public GameObject Meteor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0, spawnThreshold) <= 1)
        {
            Vector3 pos = transform.position;
            Instantiate(Meteor, new Vector3(pos.x + Random.Range(-6, 6), pos.y, pos.z), Quaternion.identity);

            spawnThreshold -= spawnDecrement;

            if(spawnThreshold < 2)
            {
                spawnThreshold = 2;
            }
        }
    }

}
