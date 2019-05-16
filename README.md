# downTownRPG
downTownRPG

## 1. 拼UI(部分)

* UIHomePanel

  ![](http://githubresources.oss-cn-shanghai.aliyuncs.com/DownTownRPG/1.Home.jpg?Expires=1555509931&OSSAccessKeyId=TMP.AQFj3k6017czSPQZtVZbo2Hjl5nYVb4vOlpoa5Yyji3saWucjfG0IvMh65ReAAAwLAIUYGgEYYHcv2UFwn3_h_QlDPMS6V0CFGZIoqVPPxIBAgDFho5t5rd-qUal&Signature=gvDJQX5oAn7DSW3jUDslp%2FxUhHE%3D)

* UIShopGoldPanel

  ![](http://githubresources.oss-cn-shanghai.aliyuncs.com/DownTownRPG/2.Shop.jpg?Expires=1555510103&OSSAccessKeyId=TMP.AQFj3k6017czSPQZtVZbo2Hjl5nYVb4vOlpoa5Yyji3saWucjfG0IvMh65ReAAAwLAIUYGgEYYHcv2UFwn3_h_QlDPMS6V0CFGZIoqVPPxIBAgDFho5t5rd-qUal&Signature=ffCLTbhpGUwwhiBqnGFgDZixC5A%3D)

* UIMapPanel

  ![](http://githubresources.oss-cn-shanghai.aliyuncs.com/DownTownRPG/3.Map.jpg?Expires=1555510223&OSSAccessKeyId=TMP.AQFj3k6017czSPQZtVZbo2Hjl5nYVb4vOlpoa5Yyji3saWucjfG0IvMh65ReAAAwLAIUYGgEYYHcv2UFwn3_h_QlDPMS6V0CFGZIoqVPPxIBAgDFho5t5rd-qUal&Signature=w2ImQuO4MWSnyKluHwKhYd40gYk%3D)

* UIMapStagesPanel

  ![](http://githubresources.oss-cn-shanghai.aliyuncs.com/DownTownRPG/4.MapStages.jpg?Expires=1555510329&OSSAccessKeyId=TMP.AQFj3k6017czSPQZtVZbo2Hjl5nYVb4vOlpoa5Yyji3saWucjfG0IvMh65ReAAAwLAIUYGgEYYHcv2UFwn3_h_QlDPMS6V0CFGZIoqVPPxIBAgDFho5t5rd-qUal&Signature=o7qxhOiIbmLNy6wrQwHPlRWr3Ws%3D)

* UIGamePanel

  ![](http://githubresources.oss-cn-shanghai.aliyuncs.com/DownTownRPG/5.GamePanel.jpg?Expires=1555510455&OSSAccessKeyId=TMP.AQFj3k6017czSPQZtVZbo2Hjl5nYVb4vOlpoa5Yyji3saWucjfG0IvMh65ReAAAwLAIUYGgEYYHcv2UFwn3_h_QlDPMS6V0CFGZIoqVPPxIBAgDFho5t5rd-qUal&Signature=o4j%2FK7MAKcP36qIiwXdDIM%2FaZmA%3D)

* UIFreeRewardPanel

  ![](http://githubresources.oss-cn-shanghai.aliyuncs.com/DownTownRPG/6.UIFreeRewardPanel.jpg?Expires=1555511137&OSSAccessKeyId=TMP.AQFj3k6017czSPQZtVZbo2Hjl5nYVb4vOlpoa5Yyji3saWucjfG0IvMh65ReAAAwLAIUYGgEYYHcv2UFwn3_h_QlDPMS6V0CFGZIoqVPPxIBAgDFho5t5rd-qUal&Signature=0JLHS7okpT6j9welKS%2FNH3TnKJc%3D)





## 2. 进度日志

### 20190429

* 背包添加物品
* 背包添加储物格
* 背包物品介绍
* 抽离TopStatus，并更新数据
* 购买钻石

### 20190430

* 购买金币，并更新topStatus数据
* 成功或失败界面
* 首页钻石、金币数量显示
* 物品详细信息显示
* 背包物品存储和加载

### 20190505

* 背包物品出售

### 20190506

* 解决背包界面增加或者卖出物品后，返回首页再进入背包页面，添加物品抛出无可用物品槽的bug

  把保存物品槽的List改为static

### 20190516

* 导航条新增标题名称
* 酒馆ui更新导航条

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




