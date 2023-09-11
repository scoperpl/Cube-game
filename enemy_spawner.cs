using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab_1;
    [SerializeField]
    private GameObject enemyPrefab_2;
    [SerializeField] private Texture2D texture_1_1;
    [SerializeField] private Texture2D texture_1_2;
    [SerializeField] private Texture2D texture_2_1;
    [SerializeField] private Texture2D texture_2_2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnenemy(Random.Range(2, 3), enemyPrefab_1));
        StartCoroutine(spawnenemy(Random.Range(4, 5), enemyPrefab_2));
    }
    private float x;
    private float y;
    private float spawn_interval;
    private float spawn_interval2;
    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("mySprite");
        x = go.transform.position.y;
        y = go.transform.position.x;
    }

    private IEnumerator spawnenemy(float interval, GameObject enemy)
    {
        if (x < 480 && y > -1 && y < 1)
        {
            yield return new WaitForSeconds(interval);
            float y = GameObject.Find("mySprite").transform.position.y;
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(10f, 15f), y + Random.Range(9, 18), 0), Quaternion.identity);
            StartCoroutine(spawnenemy(interval, enemy));
        }
    }
}
