using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            timeline.Play();
        }
    }
}
