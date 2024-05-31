using UnityEngine;

public class ToggleObjectOnTrigger : MonoBehaviour
{
    public GameObject targetObject;

    void Start()
    {
        if (targetObject == null)
        {
            Debug.LogError("ez");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}
