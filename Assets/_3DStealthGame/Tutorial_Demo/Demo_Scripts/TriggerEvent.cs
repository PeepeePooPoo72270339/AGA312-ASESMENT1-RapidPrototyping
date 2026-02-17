using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{

    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerExitEvent;
    public UnityEvent OnTriggerStayEvent;

    public void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent?.Invoke();
        OnTriggerExitEvent?.Invoke();
    }

}
