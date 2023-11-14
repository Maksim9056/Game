using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class LandscapeGenerator : MonoBehaviour
{
    public int width = 100; // ������ ��������
    public int length = 100; // ����� ��������
    public float height = 1f; // ������ ��������

    private GameObject platform; // ���������� ��� �������� ��������� ��������

    void Start()
    {
        GeneratePlatform();
    }

    void GeneratePlatform()
    {
        // �������� �������� � ������� (0, height / 2, 0) � �������� (width, height, length)
        platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
        platform.transform.position = new Vector3(0, height / 2, 0);
        platform.transform.localScale = new Vector3(width, height, length);

        // ������� �������� ����� ��������� ��������
        Renderer renderer = platform.GetComponent<Renderer>();
        renderer.material.color = Color.green;
    }

    void OnApplicationQuit()
    {
        // �������� ��������� �������� ��� �������� ����
        if (platform != null)
        {
            Destroy(platform);
        }
    }
}

//public class LandscapeGenerator : MonoBehaviour
//{
//    public int width = 100; // ������ ���������
//    public int length = 100; // ����� ���������
//    public float maxHeight = 10f; // ������������ ������ ���������

//    private GameObject[] cubes; // ������ ��� �������� ��������� �������

//    void Start()
//    {
//        GenerateLandscape();
//    }

//    void GenerateLandscape()
//    {
//        // cubes = new GameObject[width * length]; // ������������� ������� 
//        //for (int x = 0; x < width; x++)
//        //{
//        //    for (int z = 0; z < length; z++)
//        //    {
//        cubes = new GameObject[1];

//        float height = Random.Range(0f, maxHeight); // ��������� ��������� ������

//                // �������� ���� � ������� (x, height, z) � �������� 1x1x1
//                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Plane);
//                cube.transform.position = new Vector3( 1.52f, height, 0f);
//                cube.transform.localScale = new Vector3(1, 1, 1);

//                cubes[(int)(1.52 * length + 0)] = cube; // ���������� ���� � ������
//          //  }
//       // }
//    }

//    void OnApplicationQuit()
//    {
//        // �������� ���� ��������� ����� ��� �������� ����
//        if (cubes != null)
//        {
//            foreach (GameObject cube in cubes)
//            {
//                Destroy(cube);
//            }
//        }
//    }
//}


