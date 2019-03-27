# downTownRPG
downTownRPG

## 1. 拼UI

* UIGamePanel













## 涉及到的知识点

### 1. 查找对象

#### GameObject.Find

使用规范: 
1.无法查找隐藏对象 
隐藏对象包括查找路径的任何一个父节点隐藏(active=false)

2.如果查找不在最上层，建议合理使用路径查找，路径查找是把双刃剑

优点1:解决查找中可能出现的重名问题。 
优点2:如果有完全的路径，减少查找范围，减少查找时间。

缺点: 路径或结构调整后，容易影响到程序中的查找，需要重新定位查找路径。

3.如果路径查找中的任何一个父节点active=false，这个对象都将查找不到。

4.使用方便但效率低下 
此查找相当于递归遍历查找，虽使用方便但效率堪忧，建议在Start()函数中查找对象并保存引用，切忌在Update()中动态查找

#### TransForm.Find

1.可以查找隐藏对象 
2.支持路径查找 
3.查找隐藏对象的前提是transform所在的根节点必须可见，即active=true

```csharp
GameObject root = GameObject.Find("root");
root.SetActive(false); // 根节点为空

// 总是查找失败
root.transform.Find("root/AnyChildObjectName");
```

实际开发中会将功能预制体放到一个可见的GameObject目录下，将这个GameObject目录作为查找根节点，下面的所有对象(隐藏、非隐藏）都可以查找到。

你可以把”map”节点放在一个active = true的MapRoot上，无论是关闭 或者 显示 代码中写起来都很方便。 假如你的map节点就是顶级节点，那么它一旦天生acive = false ，那么你将无法得到它的对象，更无法设置它的属性了。


```csharp
GameObject root = GameObject.Find("MapRoot");

GameObject map =  root.transform.Find("map").gameObject;       
map.SetActive(true);
```




