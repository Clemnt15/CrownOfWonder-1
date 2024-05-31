using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{
    public GameObject timelineObject; // Drag the GameObject containing the PlayableDirector here in the inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is the Player
        if (other.CompareTag("Player"))
        {
            // Activate the GameObject
            if (timelineObject != null)
            {
                timelineObject.SetActive(true);
                // Optionally, you can get the PlayableDirector and play the timeline if needed
                PlayableDirector director = timelineObject.GetComponent<PlayableDirector>();
                if (director != null)
                {
                    director.Play();
                }
            }
        }
    }
}
