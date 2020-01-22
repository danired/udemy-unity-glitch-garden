using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackers;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        int idx = UnityEngine.Random.Range(0, attackers.Length);
        Spawn(idx);
        
    }

    private void Spawn(int idx)
    {
        Attacker newAttacker = Instantiate(attackers[idx], transform.position, transform.rotation);
        newAttacker.transform.parent = transform;
    }
}
