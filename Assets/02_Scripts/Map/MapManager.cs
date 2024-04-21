using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private string dataPath;
    private List<Dictionary<string, object>> data;

    public GameObject[] gameObjectsPrefabs;

    void Start()
    {
        LoadMapData(Random.Range(1, 10));

        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 15; j++)
            {
                GameObject floor = Instantiate(gameObjectsPrefabs[0]);
                floor.transform.parent = GameObject.Find("Maps").transform;
                floor.gameObject.name = floor.tag + $"( {j}, {i} )";
                floor.transform.localPosition = new Vector3(j, 0, -i);
            }
        }

        MakeMap();
    }

    public void LoadMapData(int stringNum)
    {
        dataPath = "Map/Map_" + stringNum;
        data = CSVReader.Read(dataPath);
    }

    public void MakeMap()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 15; j++)
            {
                int dataSet = (int)data[i][j.ToString()];

                if(dataSet != 0)
                {
                    GameObject mapObject = Instantiate(gameObjectsPrefabs[dataSet]);
                    mapObject.transform.parent = GameObject.Find("Maps").transform;
                    mapObject.gameObject.name = mapObject.tag + $"( {j}, {i} )";
                    mapObject.transform.localPosition = new Vector3(j, 0, -i);

                    switch (mapObject.tag)
                    {
                        case "Table":

                            break;
                        case "IngredientBox":

                            break;
                        case "FryingPan":
                            // Rotate

                            break;
                        case "Pot":
                            // Rotate

                            break;
                        case "CuttingBoard":
                            // Rotate

                            break;
                        case "Sink":
                            // Rotate

                            break;
                        case "TrashCan":

                            break;
                        case "FoodOutlet":
                            // Rotate

                            break;
                        case "Bowl":

                            break;
                    }
                }
            }
        }
    }
}
