using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawn : MonoBehaviour
{

    public GameObject skeleton;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnSkeleton", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnSkeleton()
    {
        Instantiate(skeleton, transform);
    }
}
