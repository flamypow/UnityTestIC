using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public static SceneController Instance;
    public GameObject animatorObject;
    public Animator transition;
    public float t = 0.5f;
    public bool alreadyLoading = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        alreadyLoading = false;

    }

    public void LoadScene(int index)
    {
        if (!alreadyLoading) //incase of doubleclick
        {
            alreadyLoading = true;
            animatorObject.SetActive(true);
            StartCoroutine(LoadingAnimation(index));
        }

    }

    IEnumerator LoadingAnimation(int index)
    {
        //transition.Play("SceneTransition_End");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(t);
        alreadyLoading = false;
        SceneManager.LoadScene(index);
    }

}
