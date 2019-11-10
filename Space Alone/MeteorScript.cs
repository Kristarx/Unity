using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    float speed = -5f;
    float rot;

    // Start is called before the first frame update
    void Start()
    {
        rot = Random.Range(-40, 40);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        transform.Rotate(0f, rot * Time.deltaTime, 0f);
    }
}
