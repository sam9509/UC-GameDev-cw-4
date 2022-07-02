using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject OrochimaruObject;
    public GameObject DanzoObject;

    void Spawn ()
    {
        GameObject spawnObject;

        int choice = Random.Range(0, 2);

        if (choice == 1)

            spawnObject = OrochimaruObject;
        else

            spawnObject = DanzoObject;

        int newPosition = Random.Range(-1, 2);

        Vector3 Positionv = transform.position;

        Positionv.x = Positionv.x + (5 * newPosition);

        GameObject newSpawn = Instantiate(spawnObject,Positionv,Quaternion.identity);


            }

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", 1f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
