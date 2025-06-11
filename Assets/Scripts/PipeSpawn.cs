using System.Collections;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    float spawnRate = 4f;
    float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            spawnPipe();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float HighestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,HighestPoint), 0), transform.rotation);
    }
}
