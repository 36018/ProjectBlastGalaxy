using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject monster;
    [SerializeField] private Vector2 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float spawnDelay;
    [SerializeField] private float spawnAmount;
    [SerializeField] private Transform parent;
    private float spawned;

    void Start()
    {
        StartCoroutine(StartSpawnCycle());
    }

    void SpawnSlime()
    {
        float x = Random.Range(-offset.x, offset.x);
        float y = Random.Range(-offset.y, offset.y);

        Vector3 pos = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z);
        GameObject newMonster = Instantiate(monster, pos, transform.rotation);
        newMonster.transform.SetParent(parent);
        newMonster.GetComponent<SlimeAI>().SetTarget(target);
    }

    IEnumerator StartSpawnCycle()
    {
        yield return new WaitForSeconds(Random.Range(0f, 4f));
        while(spawned < spawnAmount)
        {
            SpawnSlime();
            yield return new WaitForSeconds(spawnDelay);
            spawned++;
        }
    }
}
