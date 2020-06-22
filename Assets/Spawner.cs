using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawntimer;
    public GameObject[] obstables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawntimer += Time.deltaTime;
        if (spawntimer > 1.5f)
        {
            float xpos = Random.Range(-1.5f, 1.5f);
            int spawned = Random.Range(0, 4);
            Instantiate(obstables[spawned],new Vector3(xpos,0,0),Quaternion.identity);
            spawntimer = 0;
        }
    }
}
