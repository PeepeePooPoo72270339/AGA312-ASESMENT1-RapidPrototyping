using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;
using System;

public class WinScript : MonoBehaviour
{
    public List<GameObject> Monsters = new List<GameObject>();
    public int GhostsRemaining;
    private VisualElement m_EndScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Monsters.Count > 0)
        {
            GhostsRemaining = Monsters.Count;

        }
        if (Monsters.Count == 0)
        {
            print("YouWon");
            GhostsRemaining = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
                Monsters.RemoveAt(0);
                Monsters.RemoveAt(1);
                Monsters.RemoveAt(2);
                Monsters.RemoveAt(3);



        }
        
        
    }
    



}
