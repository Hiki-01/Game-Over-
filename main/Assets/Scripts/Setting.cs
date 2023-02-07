using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    bool Game_over=false;
    public float restT_Time=1f;
   
    public GameObject next;
    public void Next()
    {
        next.SetActive(true);
    }
    public void GameOver()
    {
        if (Game_over == false)
        {
            Game_over = true;
            Invoke("Restart", restT_Time);
          
        }
        }
   public  void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
