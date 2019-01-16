using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 面对象 
/// </summary>
public class Panel
{
    public Point[] Points;

    /// <summary>
    /// 返回面所包含的排序好的顶点, 一定是3的倍数,
    /// 现在只实现了 3 的点的面返回 Vertices 的处理
    /// </summary>
    public Vector3[] Vertices {
        get {
            Vector3[] vertices = new Vector3[Points.Length];
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = Points[i].Value;
            }
            return vertices;
        }
    }

    /// <summary>
    /// 字符串解析成面对象
    /// </summary>
    /// <param name="str"></param>
    public Panel(string str)
    {
        int beginIndex = 0;
        List<Point> pointList = new List<Point>();
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c == '(')
            {
                beginIndex = i + 1;
            }
            if (c == ')')
            {
                pointList.Add(new Point(str.Substring(beginIndex,i-beginIndex)));
            }
        }

        Points = pointList.ToArray();
    }

}
