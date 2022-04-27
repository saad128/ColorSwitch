using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private Rigidbody2D playerRB;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetIsGameActive())
        {
            if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
            {
                playerRB.velocity = Vector2.up * jumpForce;
            }
        }
    }
}
