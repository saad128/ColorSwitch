using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] private ChangeColor changeColor;


    private void Start()
    {
        gameManager = GameManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorChanger")
        {
            changeColor.ChooseRandomColor();
            gameManager.UpdateScore(10);
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != changeColor.GetCurrentColor())
        {
            Debug.Log("Game Over!");
            gameManager.GameOver();
        }

    }
}
