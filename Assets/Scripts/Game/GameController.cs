using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    [Header("Menu Components")]
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private Button btnMenu;
    [SerializeField] private Button btnReset;
    [SerializeField] private TMP_Text txtResult;

    [Header("Quote Components")]
    [SerializeField] private QuotesDataSO quoteDataSO;
    [SerializeField] private GameObject SentencePanel;
    [SerializeField] private TMP_Text sentenceText;
    [SerializeField] private Animator sentenceAnimator;
    //public QuoteData winQuoteData;
    //public QuoteData looseQuoteData;

    public bool GameEnded;

    private void Awake()
    {
        if(instance != this && instance != null){
            Destroy(this.gameObject);
        }

        instance = this;
        GameEnded = false;
    }
    private void Start()
    {
        btnMenu.onClick.AddListener(() => { SceneController.instance.LoadScene("Main Menu"); });
        btnReset.onClick.AddListener(() => { SceneController.instance.LoadScene(SceneManager.GetActiveScene().name); });
        resultPanel.SetActive(false);

        /*string WinQuotes = JsonFileReader.LoadJsonAsResource("win.json");
        winQuoteData = JsonUtility.FromJson<QuoteData>(WinQuotes);

        string LooseQuotes = JsonFileReader.LoadJsonAsResource("loose.json");
        looseQuoteData = JsonUtility.FromJson<QuoteData>(LooseQuotes);*/
    }

    public void FireOutMessage(bool fireExtinguished)
    {
        if (fireExtinguished)
        {
            quoteDataSO.win = true;
            quoteDataSO.Quotes = quoteDataSO.UsarQuotes();
        }
        else
        {
            quoteDataSO.win = false;
            quoteDataSO.Quotes = quoteDataSO.UsarQuotes();
        }
        int rand_n = Random.Range(0, quoteDataSO.Quotes.Count);
        sentenceText.text = fireExtinguished ?
                            quoteDataSO.Quotes[rand_n].sentence : quoteDataSO.Quotes[rand_n].sentence;

        sentenceAnimator.Play("QuoteEnter");

        StartCoroutine(SentenceOut());
    }

    public void SetResult(bool win)
    {
        resultPanel.SetActive(true);
        txtResult.text = win ? "GANASTE" : "PERDISTE";
        GameEnded = true;
    }

    IEnumerator SentenceOut()
    {
        yield return new WaitForSeconds(5.0f);
        sentenceAnimator.Play("QuoteOut");
    }

}