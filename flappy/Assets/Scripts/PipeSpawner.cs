using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnTimer = 1;
    private float timer = 0;
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTimer)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(0.21f, 5.33f), 0);
            Destroy(newpipe, 8);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
