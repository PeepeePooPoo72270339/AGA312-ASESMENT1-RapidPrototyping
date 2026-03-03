using UnityEngine;
using StealthGame;
public class Detection : MonoBehaviour
{
    public GameObject Ghost;
    public WaypointPatrol WaypointScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WaypointScript.CanHearPlayer = true;
        
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            WaypointScript.CanHearPlayer = false;

        }
    }

}
