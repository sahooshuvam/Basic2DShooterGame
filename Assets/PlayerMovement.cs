using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;//X-axis

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerMovement(playerSpeed);
    }

    private void CheckPlayerMovement(float speed)
    {
        if (Input.GetKey(KeyCode.RightArrow) &&  transform.position.x <= 22f)
            transform.Translate(speed, 0, 0);

        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -22f)
            transform.Translate(-speed, 0, 0);

        else if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 5)
            transform.Translate(0, speed, 0);

        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -5)
            transform.Translate(0, -speed, 0);
       
    }
}
