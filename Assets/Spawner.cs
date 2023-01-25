using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] pipes;

    private void Start()
    {
        StartCoroutine(PipeSpawn());
        Instantiate(pipes[Random.Range(0, pipes.Length)], gameObject.transform.position, Quaternion.identity);
    }

    IEnumerator PipeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            Instantiate(pipes[Random.Range(0, pipes.Length)], gameObject.transform.position, Quaternion.identity);
        }
    }
}
