using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;

public class FireController1 : MonoBehaviour
{
    [Header("Visual Components")]
    [SerializeField] private GameObject[] fireSprites;
    [SerializeField] private Color NormalColor;
    [SerializeField] private Color PressedColor;
    [SerializeField] private Color OverColor;

    [Header("Signal Components")]
    [SerializeField] private GameObject signalPrefab;
    [SerializeField] private GameObject singalCanvas;

    [Header("Fire Data")]
    public int Life;
    public float despawnTime;

    private Transform player;
    private Light2D fireLight;

    private void Awake()
    {
        despawnTime = 25f;
    }

    private void Start()
    {
        fireLight = this.GetComponentInChildren<Light2D>();
        player = PlayerController.instance.transform;

        if (singalCanvas == null)
        {
            singalCanvas = Instantiate(signalPrefab, Vector3.zero, Quaternion.identity);
            singalCanvas.transform.SetParent(GameObject.Find("Game Canvas").transform);
            singalCanvas.transform.localScale = Vector3.one;
        }
    }

    private void Update()
    {
        if (GameController.instance.GameEnded) return;

        fireLight.intensity = Mathf.Lerp(0.9f, 1.0f, Mathf.PingPong(Time.time * 5.0f, 1));
        fireLight.pointLightOuterRadius = Mathf.Lerp(5.0f, 6.4f, Mathf.PingPong(Time.time * 2.0f, 1));

        despawnTime -= Time.deltaTime;

        if (despawnTime <= 0)
        {
            GameController.instance.SetResult(false);
            GameController.instance.FireOutMessage(false);
        }
        else
        {
            singalCanvas.GetComponentInChildren<Text>().text = ((int)despawnTime).ToString();
        }
        updatePosition();

    }

    #region MouseInteractions
    private void OnMouseDown()
    {
        UpdateSpriteColor(PressedColor);

        Life--;
        checkLife();
    }

    private void OnMouseUp()
    {
        UpdateSpriteColor(OverColor);
    }

    private void OnMouseEnter()
    {
        UpdateSpriteColor(OverColor);
    }

    private void OnMouseExit()
    {
        UpdateSpriteColor(NormalColor);
    }
    #endregion

    private void UpdateSpriteColor(Color newColor){
        for (int i = 0; i < fireSprites.Length; i++)
        {
            //fireSprites[i].color = newColor;
        }
    }

    private void checkLife()
    {
        if (Life < 0)
        {
            FireGeneralController.instance.FireEliminated();
            Destroy(singalCanvas);
            Destroy(this.gameObject);
        }
    }

    private void updatePosition()
    {
        Vector3 distanceVector = transform.position - player.position;
        float distanceValue = distanceVector.magnitude;

        if (distanceValue < 7.5)
        {
            singalCanvas.SetActive(false);
            return;
        }
        else
        {
            float scale_result = (30 - distanceValue) / 30 < 0.25f ? 0.25f : (30 - distanceValue) / 30;
            singalCanvas.transform.localScale = Vector3.one * scale_result;
        }

        singalCanvas.SetActive(true);
        float relationX = distanceVector.x / 9f;
        float relationY = distanceVector.y / 5.5f;
        float X = returnResult(relationX, -370f, 370f);
        float Y = returnResult(relationY, -190f, 190f);
        singalCanvas.transform.localPosition = new Vector3(X, Y, 0f);
    }

    private float returnResult(float relation, float min, float max)
    {
        if (Mathf.Abs(relation) > 1f)
        {
            return relation > 0 ? max : min;
        }
        return relation > 0 ? max * Mathf.Abs(relation) : min * Mathf.Abs(relation);
    }
}
