using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next_Page()
    {
        SceneManager.LoadScene(1);
    }
    public void Start_Game()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }

    public void Tut_Page()
    {
        SceneManager.LoadScene(3);
    }

    public void Tut_Page2()
    {
        SceneManager.LoadScene(4);
    }

    public void Tut_Page3()
    {
        SceneManager.LoadScene(5);
    }

    public void Cockpit_View()
    {
        SceneManager.LoadScene(6);
    }

    public void Radar_View()
    {
        SceneManager.LoadScene(7);

    }
}
