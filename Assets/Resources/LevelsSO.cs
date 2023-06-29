using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LoadLevelSO", menuName = "Levels")]
public class LevelsSO : ScriptableObject
{
    public int Lvl;
    public List<Fire> fires;

    public List<Fire> LLenadoFuego()
    {
        if (Lvl == 1)
        {
            fires.Clear();
            Fire fuego1 = new Fire();
            fuego1.life = 10;
            fuego1.scale = 1;
            fuego1.x = 19.5f;
            fuego1.y = 0;
            fuego1.spawnTime = 5;
            fuego1.despawnTime = 30;
            fires.Add(fuego1);

            Fire fuego2 = new Fire();
            fuego2.life = 15;
            fuego2.scale = 1.5f;
            fuego2.x = 0;
            fuego2.y = 0;
            fuego2.spawnTime = 15;
            fuego2.despawnTime = 20;
            fires.Add(fuego2);

            Fire fuego3 = new Fire();
            fuego3.life = 5;
            fuego3.scale = 0.5f;
            fuego3.x = -24.5f;
            fuego3.y = -10;
            fuego3.spawnTime = 30;
            fuego3.despawnTime = 20;
            fires.Add(fuego3);

            Fire fuego4 = new Fire();
            fuego4.life = 15;
            fuego4.scale = 1.5f;
            fuego4.x = -24.5f;
            fuego4.y = -11.3f;
            fuego4.spawnTime = 50;
            fuego4.despawnTime = 20;
            fires.Add(fuego4);

            Fire fuego5 = new Fire();
            fuego5.life = 15;
            fuego5.scale = 1.5f;
            fuego5.x = 24.5f;
            fuego5.y = -10;
            fuego5.spawnTime = 70;
            fuego5.despawnTime = 30;
            fires.Add(fuego5);
            return fires;
        }

        else if (Lvl == 2)
        {
            fires.Clear();
            Fire fuego1 = new Fire();
            fuego1.life = 15;
            fuego1.scale = 1.5f;
            fuego1.x = 30.3f;
            fuego1.y = -2;
            fuego1.spawnTime = 5;
            fuego1.despawnTime = 20;
            fires.Add(fuego1);

            Fire fuego2 = new Fire();
            fuego2.life = 10;
            fuego2.scale = 1;
            fuego2.x = -2.1f;
            fuego2.y = 17.2f;
            fuego2.spawnTime = 10;
            fuego2.despawnTime = 15;
            fires.Add(fuego2);

            Fire fuego3 = new Fire();
            fuego3.life = 10;
            fuego3.scale = 1;
            fuego3.x = 24;
            fuego3.y = 11.1f;
            fuego3.spawnTime = 25;
            fuego3.despawnTime = 15;
            fires.Add(fuego3);

            Fire fuego4 = new Fire();
            fuego4.life = 15;
            fuego4.scale = 1.5f;
            fuego4.x = 0;
            fuego4.y = 0;
            fuego4.spawnTime = 30;
            fuego4.despawnTime = 20;
            fires.Add(fuego4);

            Fire fuego5 = new Fire();
            fuego5.life = 10;
            fuego5.scale = 1;
            fuego5.x = -21.7f;
            fuego5.y = 13.8f;
            fuego5.spawnTime = 30;
            fuego5.despawnTime = 20;
            fires.Add(fuego5);

            Fire fuego6 = new Fire();
            fuego6.life = 10;
            fuego6.scale = 1.5f;
            fuego6.x = 26.2f;
            fuego6.y = -12.6f;
            fuego6.spawnTime = 45;
            fuego6.despawnTime = 15;
            fires.Add(fuego6);
            return fires;
        }


        else if (Lvl == 3)
        {
            fires.Clear();
            Fire fuego1 = new Fire();
            fuego1.life = 15;
            fuego1.scale = 1.5f;
            fuego1.x = 33f;
            fuego1.y = 5;
            fuego1.spawnTime = 5;
            fuego1.despawnTime = 25;
            fires.Add(fuego1);

            Fire fuego2 = new Fire();
            fuego2.life = 10;
            fuego2.scale = 1;
            fuego2.x = -22.1f;
            fuego2.y = 13.3f;
            fuego2.spawnTime = 5;
            fuego2.despawnTime = 25;
            fires.Add(fuego2);

            Fire fuego3 = new Fire();
            fuego3.life = 10;
            fuego3.scale = 1;
            fuego3.x = 33.7f;
            fuego3.y = -3.1f;
            fuego3.spawnTime = 10;
            fuego3.despawnTime = 15;
            fires.Add(fuego3);

            Fire fuego4 = new Fire();
            fuego4.life = 15;
            fuego4.scale = 1.5f;
            fuego4.x = 28.6f;
            fuego4.y = -13.3f;
            fuego4.spawnTime = 30;
            fuego4.despawnTime = 15;
            fires.Add(fuego4);

            Fire fuego5 = new Fire();
            fuego5.life = 15;
            fuego5.scale = 1.5f;
            fuego5.x = 28.6f;
            fuego5.y = -13.3f;
            fuego5.spawnTime = 30;
            fuego5.despawnTime = 15;
            fires.Add(fuego5);

            Fire fuego6 = new Fire();
            fuego6.life = 5;
            fuego6.scale = 0.5f;
            fuego5.x = 26.6f;
            fuego6.y = 7.3f;
            fuego6.spawnTime = 40;
            fuego6.despawnTime = 15;
            fires.Add(fuego6);


            Fire fuego7 = new Fire();
            fuego7.life = 15;
            fuego7.scale = 1.5f;
            fuego7.x = -22.5f;
            fuego7.y = -8.5f;
            fuego7.spawnTime = 40;
            fuego7.despawnTime = 20;
            fires.Add(fuego7);


            Fire fuego8 = new Fire();
            fuego8.life = 15;
            fuego8.scale = 1.5f;
            fuego8.x = -3.7f;
            fuego8.y = 17.6f;
            fuego8.spawnTime = 60;
            fuego8.despawnTime = 20;
            fires.Add(fuego8);


            Fire fuego9 = new Fire();
            fuego9.life = 10;
            fuego9.scale = 1.0f;
            fuego9.x = 13.8f;
            fuego9.y = 13.2f;
            fuego9.spawnTime = 60;
            fuego9.despawnTime = 15;
            fires.Add(fuego9);


            Fire fuego10 = new Fire();
            fuego10.life = 5;
            fuego10.scale = 0.5f;
            fuego10.x = 13.8f;
            fuego10.y = -6.3f;
            fuego10.spawnTime = 60;
            fuego10.despawnTime = 15;
            fires.Add(fuego10);
            return fires;
        }
        else
        {
            return fires;
        }
    }
}
