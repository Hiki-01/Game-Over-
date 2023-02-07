using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
