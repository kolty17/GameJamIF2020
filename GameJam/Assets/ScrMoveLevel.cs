using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrMoveLevel : MonoBehaviour
{
    // Start is called before the first frame update
   public void GoToLv1()
    {
        SceneManager.LoadScene("Lv1", LoadSceneMode.Single);
    }
    public void GoToLvCredits()
    {
        SceneManager.LoadScene("LvCredits", LoadSceneMode.Single);
    }
    public void GoToLvTutorial()
    {
        SceneManager.LoadScene("LvTutorial", LoadSceneMode.Single);
    }
    public void GoToLvTitle()
    {
        SceneManager.LoadScene("LvTitle", LoadSceneMode.Single);
    }
}
