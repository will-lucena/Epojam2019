using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;

    public Vector3 getSpawnPoint()
    {
        return spawnPoint.position;
    }
}
