using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsSO : ScriptableObject
{
    public int Lvl;
    public List<Fire> fires;

    public void LLenadoFuego()
    {
        if (Lvl == 1)
        {
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

        }

        if (Lvl == 2)
        {
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
            fuego5.life = 10;
            fuego5.scale = 1.5f;
            fuego5.x = 26.2f;
            fuego5.y = -12.6f;
            fuego5.spawnTime = 45;
            fuego5.despawnTime = 15;
            fires.Add(fuego6);


        }


        if (Lvl == 2)
        {
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
            fuego5.life = 5;
            fuego5.scale = 0.5f;
            fuego5.x = 26.6f;
            fuego5.y = 7.3f;
            fuego5.spawnTime = 40;
            fuego5.despawnTime = 15;
            fires.Add(fuego6);


            Fire fuego7 = new Fire();
            fuego5.life = 15;
            fuego5.scale = 1.5f;
            fuego5.x = -22.5f;
            fuego5.y = -8.5f;
            fuego5.spawnTime = 40;
            fuego5.despawnTime = 20;
            fires.Add(fuego7);


            Fire fuego8 = new Fire();
            fuego5.life = 15;
            fuego5.scale = 1.5f;
            fuego5.x = -3.7f;
            fuego5.y = 17.6f;
            fuego5.spawnTime = 60;
            fuego5.despawnTime = 20;
            fires.Add(fuego8);


            Fire fuego9 = new Fire();
            fuego5.life = 10;
            fuego5.scale = 1.0f;
            fuego5.x = 13.8f;
            fuego5.y = 13.2f;
            fuego5.spawnTime = 60;
            fuego5.despawnTime = 15;
            fires.Add(fuego9);


            Fire fuego10 = new Fire();
            fuego5.life = 5;
            fuego5.scale = 0.5f;
            fuego5.x = 13.8f;
            fuego5.y = -6.3f;
            fuego5.spawnTime = 60;
            fuego5.despawnTime = 15;
            fires.Add(fuego10);

        }









    }
}
