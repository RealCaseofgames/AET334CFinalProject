using System.Collections;
using System.Collections.Generic;
using Gamekit3D;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    private bool _using;

    [SerializeField] private TransitionPoint transitionPoint;

    // Update is called once per frame
    void Update()
    {
        _using = Input.GetButton("Use");
    }

    void OnTriggerStay(Collider collider)
    {
        if (_using && collider.CompareTag("Player"))
        {
            transitionPoint.Transition();
        }
    }
}
