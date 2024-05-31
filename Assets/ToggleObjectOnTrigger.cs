using UnityEngine;
using UnityEngine.Playables;
public class ToggleObjectOnTrigger : MonoBehaviour
{
    //public GameObject targetObject;

    [SerializeField] PlayableDirector CinematicEnding;

    /*  void Start()
      {
          if (targetObject == null)
          {
              Debug.LogError("ez");
          }
      }*/

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CinematicEnding.Play();
    }
}
