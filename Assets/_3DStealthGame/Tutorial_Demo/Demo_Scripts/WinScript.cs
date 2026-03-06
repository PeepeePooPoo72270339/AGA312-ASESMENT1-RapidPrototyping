using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;
using System;
using StealthGame;

public class WinScript : MonoBehaviour
{
    public List<GameObject> Monsters = new List<GameObject>();
    public int GhostsRemaining;
    private VisualElement m_EndScreen;
    public GameEnding GameEnding;

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
            GameEnding.KillAllMonsters();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Monsters.Count >= 0) 
            {
                Monsters.RemoveAt(0);
            }
        }
    }
}
