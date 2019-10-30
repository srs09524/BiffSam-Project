using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> MyHandCards = new List<GameObject>();
    public List<GameObject> MyCardsDown = new List<GameObject>();
    public List<GameObject> OppHandCards = new List<GameObject>();
    public List<GameObject> OppCardsDown = new List<GameObject>();

    public Transform MyHandPos;
    public Transform OppHandPos;
    public Transform MyCardsDownPos;
    public Transform OppCardsDownPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
