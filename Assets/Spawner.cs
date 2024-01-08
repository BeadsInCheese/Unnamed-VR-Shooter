using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }
    public void Spawn() {
        if (ManageGame.Instance.plng&&ManageGame.Instance.zombieQuota > ManageGame.Instance.zombiesSpawned)
        {
            Vector3 pos = transform.position; // gets current location
            Instantiate(spawn, pos, Quaternion.identity);
            ManageGame.Instance.zombiesSpawned += 1;
        }
        Invoke("Spawn", Random.Range(1,5));
    }
    // Update is called once per frame
    void Update()
    {

    }
}
