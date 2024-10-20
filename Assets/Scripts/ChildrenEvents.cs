using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class ChildrenEvents : MonoBehaviour
{
    public UnityEvent unityEventIrritated, unityEventEventCalmDown;
    [SerializeField]
    private List<AudioSource> audioSourcesIrritatedList;
    private bool isIrritade = false;

    private void Awake()
    {
        unityEventEventCalmDown.AddListener(CalmDown);
        unityEventIrritated.AddListener(Irritading);
    }

    private void CalmDown()
    {
        isIrritade = false;
    }

    private void Irritading()
    {
        isIrritade = true;
    }

    private void FixedUpdate()
    {
        if (isIrritade)
        {
            if (!audioSourcesIrritatedList.Exists(audioSource => audioSource.isPlaying))
                unityEventEventCalmDown.Invoke();

            return;
        }

        if (audioSourcesIrritatedList.Exists(audioSource => audioSource.isPlaying))
            unityEventIrritated.Invoke();
    }
}
