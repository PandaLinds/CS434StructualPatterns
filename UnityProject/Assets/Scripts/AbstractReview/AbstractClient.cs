using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractClient : MonoBehaviour
{
    public NPCSpawner mNPCSpawner;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            mNPCSpawner.SpawnVillagers();
        }
        
    }
}
