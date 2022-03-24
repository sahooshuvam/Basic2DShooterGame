using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    SpawnManager spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Player").GetComponent<SpawnManager>();
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            spawn.BackToPool(collision.gameObject);
        }
    }
}
