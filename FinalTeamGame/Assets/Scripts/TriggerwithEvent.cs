using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerwithEvent : MonoBehaviour
{
    public UnityEvent triggerEnter = new UnityEvent();
    private void OnTriggerEnter(Collider col)
    {
        triggerEnter.Invoke();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
