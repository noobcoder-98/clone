using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectContainer : MonoBehaviour
{
    public bool isFull;
    public GameManager gameManager;
    public Image backgroundImage;

    private void Start()
    {
        gameManager = GameManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.draggingObject != null && !isFull)
        {
            gameManager.currentContainter = gameObject;
            backgroundImage.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.currentContainter = null;
        backgroundImage.enabled = false;
    }
}
