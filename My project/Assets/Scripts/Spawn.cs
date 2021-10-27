using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public Material Meme;
    public Material black;
    public Material blue;
    public Material red;
    public Material yellow;
    public int[] arr1 = new int[5];
    public int[] arr2 = new int[5];
    void Start()
    {
        SpawnObjects();
        planet.gameObject.SetActive(false);
    }

    private void SpawnObjects()
    {
        arr1[0] = Random.Range(0, 4);
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY, screenZ;
        Vector3 pos;
        Material random;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            screenZ = Random.Range(c.bounds.min.z, c.bounds.max.z);
            pos = new Vector3(screenX, screenY, screenZ);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            
           arr2[i] = Random.Range(0, 4);
            if (arr1[i+1]!=arr2[i])
            {
                arr1[i] = arr2[i];
            }

            if (arr1[i]==1)
            {
                toSpawn.GetComponent<Renderer>().material = yellow;
            }
            else if (arr1[i]==2)
            {
                toSpawn.GetComponent<Renderer>().material = Meme;
            }
            else if (arr1[i]==0)
            {
                toSpawn.GetComponent<Renderer>().material = black;
            }
            else if (arr1[i]==3)
            {
                toSpawn.GetComponent<Renderer>().material = blue;
            }
            else if (arr1[i]==4)
            {
                toSpawn.GetComponent<Renderer>().material = red;
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
    
    

   // void randomtexture()
  //  {
     //   GameObject mesh;
      
     //   for (int i = 0; i < numberToSpawn; i++)
    //    {
           
            
           


      //  }
  //  }

}