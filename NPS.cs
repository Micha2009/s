using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    // hp
    int health = 5;

    // lvl
    int level = 1;

    // speed
    float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("HP" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
