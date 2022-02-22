using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemyPrefab;
    public Vector3 offset;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Instantiate(bulletPrefab,transform.position + offset, Quaternion.identity);

        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            float x = Random.Range(-21f, 21f);
            float y = Random.Range(0f, 4f);
            Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
            time = 0f;
        }
    }

    
}
