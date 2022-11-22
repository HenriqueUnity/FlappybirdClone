using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float height;
    [SerializeField] private float distance;
    [SerializeField] private float timer;
    [SerializeField] private float maxTime;
    [SerializeField] private GameObject pipe;
    private List<GameObject> newpipe = new List<GameObject>();
    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        newpipe.Add(Instantiate(pipe));
        newpipe.Last().transform.position = new Vector3(distance, (Random.Range(-height, height)), 0);
        StartCoroutine(DestroyPipe(newpipe.Last()));

    }

    IEnumerator DestroyPipe(GameObject newpipe)
    {
        yield return new WaitForSeconds(8f);
        Destroy(newpipe);
    }

}
