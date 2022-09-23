using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainter;

    public static GameManager instance;

    private void Awake()
    {
        instance = this; 
    }

    public void PlaceObject()
    {
        if (draggingObject != null && currentContainter != null)
        {
            Instantiate(draggingObject.GetComponent<ObjectDragging>().card.objectGame, currentContainter.transform);
            currentContainter.GetComponent<ObjectContainer>().isFull = true;
        }
    }
}
