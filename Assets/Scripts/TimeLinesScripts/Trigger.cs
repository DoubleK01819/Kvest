using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private TimeLineStartDestroyBridge _time;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _time.ActiveTimeLine();
    }
}
