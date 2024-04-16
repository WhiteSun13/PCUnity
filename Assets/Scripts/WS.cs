using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WS : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;
    public bool DesroyMusic = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnFadeComplete()
    {
        if (DesroyMusic == true)
        {
            FindObjectOfType<AudioManager>().Stop();
        }
        SceneManager.LoadScene(levelToLoad);
    }
}
