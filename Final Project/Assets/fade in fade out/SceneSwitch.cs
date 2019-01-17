using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{

    public Animator ani;
    private int levelToload;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z) || grow.tree_height == 5)
        {
            //ani.SetTrigger("Scene Switch");
            //LoadScene();
            FadeToNextLevel();

        }
    }


    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void FadeToLevel(int index)
    {
        levelToload = index;
        ani.SetTrigger("Scene Switch");
    }


    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToload);
    }

}
