using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private string Name;
    public void PlayGame()
    {
        SceneManager.LoadScene(Name); // will load the game/change scenes when play is pressed
    }

}
