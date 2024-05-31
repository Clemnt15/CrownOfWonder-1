using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance = null;
    public static BackgroundMusic Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        // Si une instance de ce script existe déjà, détruisez cette nouvelle instance
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        // Sinon, assignez cette instance et marquez-la pour qu'elle ne soit pas détruite lors des changements de scène
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        // Assurez-vous que l'AudioSource est joué au démarrage
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null && !audio.isPlaying)
        {
            audio.Play();
        }
    }
}
