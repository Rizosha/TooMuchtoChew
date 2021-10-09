using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemy : MonoBehaviour
{
    
        
        public GameObject enemyPrefab;
        public float respawnTime = 1.0f;
        private Vector2 screenBounds;

        // Use this for initialization
        void Start()
        {

            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            StartCoroutine(enemyWave());
        }
        private void spawnEnemy()
        {
        // Spawns an enemy using instantiate and Vector 2 
            GameObject a = Instantiate(enemyPrefab) as GameObject;
            a.transform.position = new Vector2(screenBounds.x * (2 * Time.deltaTime), Random.Range(-screenBounds.y, screenBounds.y));
        }
        IEnumerator enemyWave()
        {
         // here we use the WaitForSeconds to give a delay before the next enemy is created.

                yield return new WaitForSeconds(respawnTime);
                spawnEnemy();
           
        }
    
}
