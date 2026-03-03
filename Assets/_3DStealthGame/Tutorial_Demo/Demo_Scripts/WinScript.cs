using UnityEngine;
using UnityEngine.UIElements;

public class WinScript : MonoBehaviour
{
    public GameObject[] Monsters;
    public int GhostsRemaining;
    private VisualElement m_EndScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GhostsRemaining = Monsters.Length;
        if (Monsters.Length == 0)
        { 
        
        
        }
        
    }
}
