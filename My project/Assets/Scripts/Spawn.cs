using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Spawn : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public List<Material> a;
    public GameObject quad;
    public GameObject planet;
    public int random_index;
    private int randomname;
    public int x;
    public Material white;
    public Material black;
    public Material blue;
    public Material red;
    public Material yellow;
    public Material gray;
    int[] num = {1,2,3,4,5};
    public int n = 0;
    public int[] num2 = {0,0,0,0,0,0};
    void Start()
    {
        SpawnObjects();
        planet.gameObject.SetActive(false);
    }

    private void SpawnObjects()
    {
       
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY, screenZ;
        Vector3 pos;



        /*bool checkrep( int n, int[] num)
        {
            for (int i = 0; i < 5; i++)
            {
                if (n == num[i])
                {
                    return true;
                }

                return false;
            }
        }*/
        for (int j = 0; j <= 5; j++)
        {
            n = Random.Range(0, 5);
            //Debug.Log(n);
            if (!num2.Contains(num[n]))
            {
                num2[j] = num[n];

            }

        }
        foreach (int p in num2)
        {
            print(p);
        }




        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            screenZ = Random.Range(c.bounds.min.z, c.bounds.max.z);
            pos = new Vector3(screenX, screenY, screenZ);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            if (num2[i] == 1)
            {
                toSpawn.GetComponent<Renderer>().material = yellow;
            }
            else if (num2[i] == 2)
            {
                toSpawn.GetComponent<Renderer>().material = white;
            }
            else if (num2[i] == 5)
            {
                toSpawn.GetComponent<Renderer>().material = black;
            }
            else if (num2[i] == 3)
            {
                toSpawn.GetComponent<Renderer>().material = blue;
            }
            else if (num2[i] == 4)
            {
                toSpawn.GetComponent<Renderer>().material = red;
            }
            else if (num2[i] == 0)
            {
                toSpawn.GetComponent<Renderer>().material = gray;
            }






        }
    }
    private void destroyObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawn"))
        {
            Destroy(o);
        }
    }

    
    

  

}