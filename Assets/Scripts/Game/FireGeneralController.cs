using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FireGeneralController : MonoBehaviour
{
    public static FireGeneralController instance;
    [SerializeField] private GameObject firePrefab;
    private List<GameObject> fireList;
    private LevelData levelDataObject;
    private int level;
    private List<float> spawnTimers;
    private float timeElapsed;
    private float mayorSpawnTime;
    private float actual_wait_time;
    private int countFires;
    private int totalFires;
    [SerializeField] LevelsSO LevelsSO;

    private void Awake()
    {
        CreateSingleton();
        
        if (PlayerPrefs.GetInt("level") == 4)
        {
            InstantiateRandomFire();
            return;
        }

        List<Fire> FireData = LevelsSO.LLenadoFuego();

        spawnTimers = new List<float>();

        foreach (Fire data in FireData)
        {
            Vector3 position = new Vector3(data.x, data.y);

            GameObject newFire = Instantiate(firePrefab, position, Quaternion.identity);
            newFire.GetComponent<FireController1>().Life = data.life;
            newFire.GetComponent<FireController1>().despawnTime = data.despawnTime;
            newFire.transform.localScale = new Vector3(data.scale, data.scale, 1);
            
            spawnTimers.Add(data.spawnTime);
            newFire.SetActive(false);
            fireList.Add(newFire);
        }
    }

    private void Start()
    {
        timeElapsed = 0f;
        countFires = 0;
        if (PlayerPrefs.GetInt("level") == 4)
        {
            InstantiateRandomFire();
            return;
        }
        totalFires = fireList.Count;
        mayorSpawnTime = spawnTimers.Max();
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (PlayerPrefs.GetInt("level") == 4)
        {
            if (timeElapsed >= actual_wait_time) InstantiateRandomFire();
        }
        else
        {
            SetFire();
        }
    }

    //Singleton Set Up
    private void CreateSingleton()
    {
        if(instance != this && instance != null){
            Destroy(this.gameObject);
        }

        instance = this;
    }

    //Read levels data
    private List<Fire> ReadJson(){
        fireList = new List<GameObject>();

        string levelData = JsonFileReader.LoadJsonAsResource("levels.json");
        levelDataObject = JsonUtility.FromJson<LevelData>(levelData);

        return levelDataObject.levels[PlayerPrefs.GetInt("level")].fires;
    }


    //Spawn Fire Prefabs as the timeElpased reaches the time to spawn and validates if it is finished
    private void SetFire()
    {
        for (int i = 0; i < spawnTimers.Count; i++)
        {
            if (timeElapsed >= spawnTimers[i])
            {
                spawnTimers[i] = Mathf.Infinity; //caquita
                fireList[i].SetActive(true);
            }
        }

        if (countFires == totalFires)
        {
            GameController.instance.SetResult(true);
        }

        if (timeElapsed > mayorSpawnTime)
        {
            spawnTimers.Clear();
        }
    }

    //Insatiate FirePrefab under random condicions, for Procedural Level Only
    private void InstantiateRandomFire()
    {
        GameObject newFire = Instantiate(firePrefab, RandomPosition(), Quaternion.identity);
        newFire.GetComponent<FireController1>().Life = Random.Range(2, 10);
        newFire.GetComponent<FireController1>().despawnTime = Random.Range(25, 50);

        float scale_t = Random.Range(1, 5);
        newFire.transform.localScale = new Vector3(scale_t, scale_t, 1);

        actual_wait_time = Random.Range(5, 10);
        timeElapsed = 0;
    }

    private Vector3 RandomPosition()
    {
        float x = Random.Range(-35, 35);
        float y = Random.Range(-10, 20);
        return new Vector3(x, y, 0);
    }

    public void FireEliminated()
    {
        countFires++;
        GameController.instance.FireOutMessage(true);
    }
}
