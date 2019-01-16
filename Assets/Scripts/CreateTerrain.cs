using System.IO;
using UnityEngine;

/// <summary>
/// 创建地形的脚本
/// </summary>
public class CreateTerrain : MonoBehaviour
{
    /// <summary>
    /// 地形文件所在 Streamingassets 下的地址
    /// </summary>
    public string Path = "Test1.terrain";

    /// <summary>
    /// 地形对象
    /// </summary>
    public MyTerrain MyTerrain;

    /// <summary>
    /// 地形材质
    /// </summary>
    public Material Material;

    private void Awake()
    {
        string realPath = Application.streamingAssetsPath + "/" + Path;
        if (File.Exists(realPath))
        {
            //字符流读取地形文件,并创建地形对象
            MyTerrain = new MyTerrain(File.ReadAllText(realPath));
        }

        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = Material;
        MyTerrain.SetMeshFilter(meshFilter);
    }
}
