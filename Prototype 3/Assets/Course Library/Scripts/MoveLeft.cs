using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // getting the object from the a different script
    private PlayerController playerControllerScript;
    // the movement of the background and obstacles
    public float speed = 20.0f;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {// finding the object from the player controller script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {// As long as the player do not bump to the obstacle, it will move
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // when the spawned obstacle pass by the player it will get destroyed
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
