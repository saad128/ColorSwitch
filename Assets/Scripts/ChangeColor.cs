using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private string currentColor;

    [SerializeField] private Color colorCyan;
    [SerializeField] private Color colorYellow;
    [SerializeField] private Color colorPink;
    [SerializeField] private Color colorPurple;
    void Start()
    {
        ChooseRandomColor();
    }

    public string GetCurrentColor()
    {
        return currentColor;
    }

    public void ChooseRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
            case 3:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
        }
    }

}
