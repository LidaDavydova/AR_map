using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manage_button : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScenes(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}


