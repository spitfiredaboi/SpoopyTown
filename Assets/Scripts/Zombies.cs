using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public GameObject player;
    public Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.transform.position - transform.position;

        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}
