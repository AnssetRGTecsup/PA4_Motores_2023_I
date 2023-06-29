using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public static SceneController instance { get; private set; }
    [SerializeField] private Canvas canvas;
    [SerializeField] private Animator animator;
    [SerializeField] private string level_to_load;
    [SerializeField] private LevelsSO levelsSO;
    public Action onFade;
    public Action onLoadScene;

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
        onFade += FadeIn;
        onLoadScene += OnFadeComplete;
        canvas.worldCamera = Camera.main;
    }

    public void LoadScene(string level_to_load)
    {
        AudioController.instance.PlayButtonSound();
        animator.Play("FadeOut");
        this.level_to_load = level_to_load;
        onFade?.Invoke();
    }

    private void FadeIn()
    {
        Debug.Log("Play fade in");
        animator.Play("FadeIn");
        onLoadScene?.Invoke();
    }

    public void OnFadeComplete()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    public IEnumerator LoadSceneCoroutine(){
        Debug.Log(this.level_to_load);
        AsyncOperation asyncLoadLevel = SceneManager.LoadSceneAsync(this.level_to_load, LoadSceneMode.Single);

        while (!asyncLoadLevel.isDone){
            Debug.Log("Loading the Scene"); 
            yield return null;
        }

        switch (level_to_load)
        {
            case "Main Menu":
                AudioController.instance.ChangeOst(AudioController.instance.menuTheme);
                break;
            case "Level":
                AudioController.instance.ChangeOst(AudioController.instance.gameTheme);
                break;
        }
    }
}