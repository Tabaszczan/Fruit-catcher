using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitLauncher : MonoBehaviour
{
    public List<GameObject> flyingObjecList;
    private float thrust = 10.0f;
    private GameObject randomItem;
    private GameObject clone;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(GenerateObject());
    }



    // Update is called once per frame
        void Update()
    {


    }

        IEnumerator GenerateObject()
        {
            while (true)
            {
                rand = Random.Range(0, flyingObjecList.Count);
                if (rand == flyingObjecList.Count)
                {
                    if (Random.value >= 0.98)
                    {
                        randomItem = flyingObjecList[rand];
                        
                    }
                    else
                    {
                        randomItem = flyingObjecList[Random.Range(0, flyingObjecList.Count - 1)];
                    }
                }
                else
                {
                    randomItem = flyingObjecList[rand];
                }
            clone = Instantiate(randomItem, transform);
                clone.GetComponent<Rigidbody2D>().AddForce(
                    new Vector2(
                        thrust * clone.GetComponent<Rigidbody2D>().mass * -Random.Range(60,100),
                        thrust * clone.GetComponent<Rigidbody2D>().mass * Random.Range(0, 20)), 
                    ForceMode2D.Force);
                clone.GetComponent<Rigidbody2D>().MoveRotation(Random.Range(0, flyingObjecList.Count) * 20);
                yield return new WaitForSeconds(Random.Range(1, 7));
            }
            StopCoroutine(GenerateObject());
        }

}
