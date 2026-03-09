using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GhostCounter : MonoBehaviour
{
    public GameObject GameManager;
    public TMP_Text GhostRemaining;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GhostRemaining.text = GameManager.GetComponent<WinScript>().GhostsRemaining.ToString();

    }
}
