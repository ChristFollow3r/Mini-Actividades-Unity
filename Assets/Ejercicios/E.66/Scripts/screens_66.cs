using UnityEngine;
using UnityEngine.SceneManagement;

public class screens_66 : MonoBehaviour
{
    private float sceneTimer = 10f;

    void Update()
    {
        sceneTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)) LoadRedScene(); // https://www.youtube.com/watch?v=XMlDgtIhtD0
        if (sceneTimer <= 0f)
        {
            sceneTimer = 10f;
            LoadGreenScene();
        }
    }


    void LoadRedScene()
    {
        SceneManager.LoadScene("e66_Red");
    }
    void LoadGreenScene()
    {
        SceneManager.LoadScene("e66_Green");
    }
}
