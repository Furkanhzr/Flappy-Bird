using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipesPrefab;
    [SerializeField] private float pipeSpawnTime = 1.5f;
    [SerializeField] private float height = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe() //Coroutine açtık. Coroutine zamana yayarak işlemler yapmak için kullanılır. ("şimdi biraz çalış, biraz bekle, sonra devam et" tarzı çalışır.) // Bunu IEnumerator ile belitririz.
    {
        while(true)
        {
            Instantiate(pipesPrefab, new Vector3(3f, Random.Range(-height, height), 0), Quaternion.identity); //Instantiate, prefab'ı sahnede oluşturur. 
            yield return new WaitForSeconds(pipeSpawnTime); // 2 saniye bekle
            //Quaternion.identity default rotation için
        }
    }
   
}
