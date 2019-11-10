using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f; //gamer speed
    public GameObject bullet; //prefabric bullet
    public GameControlScript control; //Control script
    public float bulletThreshold = 0.5f; //gamer shot 0,5s
    float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; //monitoring time for shooting bullets

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f); //move gamer's object

        if(Input.GetButtonDown("Jump")) //check if space
        {
            if(elapsedTime > bulletThreshold) //check if enough time to fire
            {
                //shoot bullet in present posision, make sure you've created bullet before gamer to avoid collision between them
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1.2f, -5f), Quaternion.identity);
                elapsedTime = 0f;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        control.PlayerDied();
        Destroy(this.gameObject);
    }
}
