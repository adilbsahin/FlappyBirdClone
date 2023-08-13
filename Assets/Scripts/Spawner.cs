using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird birdScript;

    public GameObject Borular;

    public float height;

    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject (time));
    }

    //boru üretimi
    public IEnumerator SpawnObject(float time)
    {
        while(!birdScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }        
    }
}
