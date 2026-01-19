using UnityEngine;
using UnityEngine.SceneManagement;

public class exitScript : MonoBehaviour
{
    public static exitScript singelton;

    void Awake()
    {
        if (singelton != null && singelton != this)
        {
            Destroy(gameObject);
            return;
        }
        singelton = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(70);
    }

}
