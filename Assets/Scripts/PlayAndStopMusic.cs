using UnityEngine;

public class PlayAndStopMusic : MonoBehaviour
{
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        if (m_AudioSource.isPlaying)
        {
            m_AudioSource.Pause();

            return;
        }

        m_AudioSource.Play();
    }
}
