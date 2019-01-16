using UnityEngine;

public class Point
{
    public Vector3 Value;

    /// <summary>
    /// 字符解析成点对象
    /// </summary>
    /// <param name="str"></param>
    public Point(string str)
    {
        char[] buffer = new char[5];
        int i = 0;
        int ivalue = 0;
        foreach (var c in str)
        {
            if (c != ',')
            {
                buffer[i++] = c;
            }
            else
            {
                Value[ivalue++] = float.Parse(new string(buffer,0,i));

                i = 0;
                buffer = new char[5];
            }
        }
        Value[ivalue++] = float.Parse(new string(buffer, 0, i));
    }

}
