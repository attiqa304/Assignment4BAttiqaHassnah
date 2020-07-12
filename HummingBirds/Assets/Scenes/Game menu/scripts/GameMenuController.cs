using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    public void ClickOnPenguin()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void ClickOnHummingbird()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
}

