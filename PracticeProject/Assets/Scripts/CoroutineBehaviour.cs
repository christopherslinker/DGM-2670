using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    public bool canRun = true;

    public float holdTime = 2f;

    private WaitForSeconds _wfs;
    // Start is called before the first frame update
    private IEnumerator Start()
    {
        _wfs = new WaitForSeconds(holdTime);
        
        while (canRun)
        {
            yield return _wfs;
            startEvent.Invoke();
        }
    }
}
