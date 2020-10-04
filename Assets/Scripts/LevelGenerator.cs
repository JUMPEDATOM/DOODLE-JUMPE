using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class LevelGenerator : MonoBehaviour
{
    public Transform target;
    public GameObject platformPrefab;
    public Transform Platfrom;
    public int lastPos;
    public int numberofplatform = 200;
    public float LevelWidth = 3f;
    public float minY = 0.2f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
     void Start()
    {
      Vector3 spawnPosition = new Vector3();
      for (int i = 0; i < numberofplatform; i++)
      {
          spawnPosition.y += Random.Range(minY, maxY);
          spawnPosition.x = Random.Range(-LevelWidth, LevelWidth);
          Instantiate(platformPrefab, spawnPosition, Quaternion.identity); // create platform , we wont rotate the platform(Quaternion.identity)
          if (i == numberofplatform - 1) {

            lastPos = (int)spawnPosition.y;
       }
     }
 }

    void Update()
    {
      if(target.position.y >= lastPos + 3)
      {
        Timer.finished = true;
        StartCoroutine (WaitForIt (1.5F));
      }
    }

    IEnumerator WaitForIt(float waitTime)
    {
    yield return new WaitForSeconds(waitTime);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
