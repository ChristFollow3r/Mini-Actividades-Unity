using UnityEngine;
using UnityEngine.SceneManagement;

public class Red : MonoBehaviour
{

    private float sceneTimer = 10f;

    void Update()
    {
        sceneTimer -= Time.deltaTime;
        if (sceneTimer <= 0f)
        {
            sceneTimer = 10f;
            LoadGreenScene();
        }
    }

    void LoadGreenScene()
    {
        SceneManager.LoadScene("e66_Green");
    }

    public void LoadBlueScene()
    {
        SceneManager.LoadScene("e66_Blue");
    }
}
