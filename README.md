# SampleTerrain
## 简单实现 读取文件生成地形
创建或修改 Asset/Streamingasset 目录下的 .terran文件  
在编辑器 游戏物体的CreateTerrain脚本 的文件路径字段中指定这个文件的目录  
既可 自动读取并创建相应地形  

## .terran 格式
[]中括号代表一个面  
()代表一个点，点只能由数字和逗号组成，逗号分割数字  
未作错误处理  