using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public List<GameObject> enemies;
    public List<GameObject> doors;
    bool roomExplored = false;

    void Start()
    {

    }

    void Update()
    {
        if (!roomExplored && enemies.Count == 0)
        {
            roomExplored = true;
            foreach (GameObject go in doors)
            {
                go.GetComponent<DoorController>().ChangeDoorState(DoorController.DoorState.movingUp);
            }
        }
    }
}
