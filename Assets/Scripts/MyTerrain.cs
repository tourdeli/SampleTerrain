using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 地形对象
/// </summary>
public class MyTerrain
{
    public Panel[] Panels;

    public Vector3[] Vertices {
        get {
            List<Vector3> vertices = new List<Vector3>();
            foreach (var panel in Panels)
            {
                vertices.AddRange(panel.Vertices);
            }
            return vertices.ToArray();
        }
    } 

    /// <summary>
    /// 字符串解析成 地形对象
    /// </summary>
    /// <param name="str"></param>
    public MyTerrain(string str)
    {
        int beginIndex = 0;
        List<Panel> pointList = new List<Panel>();
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c == '[')
            {
                beginIndex = i + 1;
            }
            if (c == ']')
            {
                pointList.Add(new Panel(str.Substring(beginIndex,i-beginIndex)));
            }
        }

        Panels = pointList.ToArray();
    }

    /// <summary>
    /// 使用地形对象设置 MeshFilter
    /// </summary>
    /// <param name="meshFilter"></param>
    public void SetMeshFilter(MeshFilter meshFilter) {
        Mesh mesh = meshFilter.mesh;
        mesh.vertices = Vertices;

        int[] triangles = new int[Vertices.Length];
        for (int i = 0; i < triangles.Length; i++)
        {
            triangles[i] = i;
        }
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}
