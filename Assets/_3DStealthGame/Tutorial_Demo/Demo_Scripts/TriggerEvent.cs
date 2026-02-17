using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public string[] checkTag;
    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerExitEvent;
    public UnityEvent OnTriggerStayEvent;

    public void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < checkTag.Length; i++)
        {
            if (other.gameObject.CompareTag(checkTag[i]))
            OnTriggerEnterEvent?.Invoke();

        }
     
    
    }

    public void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < checkTag.Length; i++)
        {
            if (other.gameObject.CompareTag(checkTag[i]))
                OnTriggerExitEvent?.Invoke();

        }


    }


}
