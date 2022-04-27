using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicleRotator : MonoBehaviour
{
    public float rotationSpeed = 100f;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
        GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetIsGameActive())
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }
}
