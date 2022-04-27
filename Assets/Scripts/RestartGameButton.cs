using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class RestartGameButton : MonoBehaviour
{
    public Button restartButton;
    void Start()
    {
        OnScaleAndColorChange();
    }

    void OnScaleAndColorChange()
    {
        var sequence = DOTween.Sequence().Append(restartButton.transform.DOScale(1.5f, 1f).SetEase(Ease.InOutSine))
            .Join(restartButton.image.DOColor(Color.red, 1f).SetEase(Ease.InOutSine));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }

    public void RestartGame()
    {
        Destroy(GameManager.instance);
        Destroy(GameManager.instance.gameObject);
        SceneManager.LoadScene(0);
    }
}
