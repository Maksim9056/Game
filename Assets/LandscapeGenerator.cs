using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class LandscapeGenerator : MonoBehaviour
{
    public int width = 100; // Ширина площадки
    public int length = 100; // Длина площадки
    public float height = 1f; // Высота площадки

    private GameObject platform; // Переменная для хранения созданной площадки

    void Start()
    {
        GeneratePlatform();
    }

    void GeneratePlatform()
    {
        // Создание площадки в позиции (0, height / 2, 0) с размером (width, height, length)
        platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
        platform.transform.position = new Vector3(0, height / 2, 0);
        platform.transform.localScale = new Vector3(width, height, length);

        // Задание зеленого цвета материалу площадки
        Renderer renderer = platform.GetComponent<Renderer>();
        renderer.material.color = Color.green;
    }

    void OnApplicationQuit()
    {
        // Удаление созданной площадки при закрытии игры
        if (platform != null)
        {
            Destroy(platform);
        }
    }
}

//public class LandscapeGenerator : MonoBehaviour
//{
//    public int width = 100; // Ширина ландшафта
//    public int length = 100; // Длина ландшафта
//    public float maxHeight = 10f; // Максимальная высота ландшафта

//    private GameObject[] cubes; // Массив для хранения созданных кубиков

//    void Start()
//    {
//        GenerateLandscape();
//    }

//    void GenerateLandscape()
//    {
//        // cubes = new GameObject[width * length]; // Инициализация массива 
//        //for (int x = 0; x < width; x++)
//        //{
//        //    for (int z = 0; z < length; z++)
//        //    {
//        cubes = new GameObject[1];

//        float height = Random.Range(0f, maxHeight); // Генерация случайной высоты

//                // Создание куба в позиции (x, height, z) с размером 1x1x1
//                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Plane);
//                cube.transform.position = new Vector3( 1.52f, height, 0f);
//                cube.transform.localScale = new Vector3(1, 1, 1);

//                cubes[(int)(1.52 * length + 0)] = cube; // Добавление куба в массив
//          //  }
//       // }
//    }

//    void OnApplicationQuit()
//    {
//        // Удаление всех созданных кубов при закрытии игры
//        if (cubes != null)
//        {
//            foreach (GameObject cube in cubes)
//            {
//                Destroy(cube);
//            }
//        }
//    }
//}


