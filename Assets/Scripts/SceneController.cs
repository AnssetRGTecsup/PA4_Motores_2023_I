using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public static SceneController instance { get; private set; }
    [SerializeField] private Canvas canvas;
    [SerializeField] private Animator animator;
    private string level_to_load;
    private Action onFade;
    private Action onLoadScene;

    private void Awake()
    {
        if(instance != this && instance != null){
            Destroy(this.gameObject);
        }

        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        canvas.worldCamera = Camera.main;
    }

    public void LoadScene(string level_to_load)
    {
        AudioController.instance.PlayButtonSound();
        animator.Play("FadeOut");
        level_to_load = this.level_to_load;
    }

    private void FadeIn()
    {
        Debug.Log("Play fade in");
        animator.Play("FadeIn");
    }

    public void OnFadeComplete()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    public IEnumerator LoadSceneCoroutine(){

        AsyncOperation asyncLoadLevel = SceneManager.LoadSceneAsync(this.level_to_load, LoadSceneMode.Single);

        while (!asyncLoadLevel.isDone){
            Debug.Log("Loading the Scene"); 
            yield return null;
        }

        switch (level_to_load)
        {
            case "Menu Principal":
                AudioController.instance.ChangeOst(AudioController.instance.menuTheme);
                break;
            case "World":
                AudioController.instance.ChangeOst(AudioController.instance.gameTheme);
                break;
        }
    }
}