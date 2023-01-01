using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public void loadAppleScene()
    {
        SceneManager.LoadScene("Apple", LoadSceneMode.Single);
    }
    public void loadDonutScene()
    {
        SceneManager.LoadScene("Donut", LoadSceneMode.Single);
    }
}
