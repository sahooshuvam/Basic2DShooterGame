using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemyPrefab;
    public Vector3 offset;
    public float time;

    Stack<GameObject> bullet = new Stack<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        CreateBullet(10);  
    }

    private void CreateBullet(int value)
    {
        for (int i = 0; i < value; i++)
        {
            bullet.Push(Instantiate(bulletPrefab));
            bulletPrefab.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBullet();
        }

        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            float x = Random.Range(-21f, 21f);
            float y = Random.Range(0f, 4f);
            Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
            time = 0f;
        }
    }

    public void SpawnBullet()
    {
        GameObject temp = bullet.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position + offset;
    }

    public void BackToPool(GameObject obj)
    {
        bullet.Push(obj);
        bullet.Peek().SetActive(false);
    }
}
