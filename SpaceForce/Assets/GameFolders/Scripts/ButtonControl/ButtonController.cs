using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
   public void F_ObjectPassive(GameObject obj)
   {
        obj.SetActive(false);
   }
    public void F_ObjectActive(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void F_LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void F_OpenUrl(string url)
    {
        Application.OpenURL(url);
    }
    public void F_Quit()
    {
        Application.Quit();
    }
    public void F_TimeControl(int GameTime)
    {
        Time.timeScale = GameTime;
    }
}
