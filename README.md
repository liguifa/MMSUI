# MMSUI
一个简单的 WPF UI框架<br />
这是一个简单的实例图：
![image](https://github.com/liguifa/MMSUI/blob/master/example.png)

使用方式：
step1:在WPF App.xaml的<Application.Resources>中加入以下代码：
     <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <ResourceDictionary Source="/MMS.UI;Component/Themes/Generic.xaml" />
          </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
step2:修改MainWindow.cs 继承MMS.UI.Default.Window
step3:在MainWindow.xaml中引入MMS.UI.Default,即:xmlns:src="clr-namespace:MMS.UI.Default;assembly=MMS.UI" 
      改Window为src:Window
