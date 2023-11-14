using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Camera MenuCamera;
    public AudioSource CameraAudioSource;
    public AudioClip PlayButtonSfx;
   
    private void Start()
    {
        CameraAudioSource = MenuCamera.GetComponent<AudioSource>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("OverWorld");
    }
  
    public void QuitGame()
    {
        Debug.Log("Quit!");

        Application.Quit();
    }
}
