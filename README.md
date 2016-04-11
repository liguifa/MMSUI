# MMSUI
一个简单的 WPF UI框架<br />
<b>这是一个简单的实例图：</b>
![image](https://github.com/liguifa/MMSUI/blob/master/example.png)
<br />
使用方式：<br />
<strong>step1:</strong><br />
&nbsp;&nbsp;&nbsp;&nbsp;在WPF App.xaml的<Application.Resources>中加入以下代码：<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<ResourceDictionary><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<ResourceDictionary.MergedDictionaries><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<ResourceDictionary Source="/MMS.UI;Component/Themes/Generic.xaml" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</ResourceDictionary.MergedDictionaries><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</ResourceDictionary><br />
<strong>step2:</strong><br />
&nbsp;&nbsp;&nbsp;&nbsp;修改MainWindow.cs 继承MMS.UI.Default.Window
<strong>step3:</strong><br />
&nbsp;&nbsp;&nbsp;&nbsp;在MainWindow.xaml中引入MMS.UI.Default,即:xmlns:src="clr-namespace:MMS.UI.Default;assembly=MMS.UI",改Window为src:Window
