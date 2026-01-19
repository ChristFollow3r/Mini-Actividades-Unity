using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour
{
    public AudioSource music;

    void Awake()
    {
        DontDestroyOnLoad(music);
    }

    void Start()
    {
        music.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("e67_Blue");
        }
    }
}
