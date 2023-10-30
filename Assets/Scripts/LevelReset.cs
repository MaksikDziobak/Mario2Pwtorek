using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelReset : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < -4)
            {
                SceneManager.LoadSceneAsync("Level_1");
            }
    }
}
