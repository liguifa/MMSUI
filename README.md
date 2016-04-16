# MMSUI 一个简单的 WPF UI框架

## 功能介绍

提供WPF桌面开发的各种控件，样式将会模仿WEB前端框架的UI样式，包括Amazeui,Easyui,AvePointUI等.

## 项目实现

使用C#编写，使用XAML资源文件的形式实现.

## 使用例图

![image](https://github.com/liguifa/MMSUI/blob/master/example.png)

## s使用方式

<strong>step1:</strong><br />
&nbsp;&nbsp;&nbsp;&nbsp;在WPF App.xaml的<Application.Resources>中加入以下代码：<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xmp><ResourceDictionary></xmp><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xmp><ResourceDictionary.MergedDictionaries></xmp><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xmp><ResourceDictionary Source="/MMS.UI;Component/Themes/Generic.xaml" /></xmp><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xmp></ResourceDictionary.MergedDictionaries></xmp><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<xmp></ResourceDictionary></xmp><br />
<strong>step2:</strong><br />
&nbsp;&nbsp;&nbsp;&nbsp;修改MainWindow.cs 继承MMS.UI.Default.Window<br />
<strong>step3:</strong><br />
&nbsp;&nbsp;&nbsp;&nbsp;在MainWindow.xaml中引入MMS.UI.Default,即:xmlns:src="clr-namespace:MMS.UI.Default;assembly=MMS.UI",改Window为src:Window

## 更新日志

开发中 如果有兴趣就加入一起吧

## 问题反馈

有问题的话，<a href="https://github.com/liguifa/mmsui/issues/new">报个issue</a>吧！

## 关于作者

本项目的作者是C#后端工程师；  
他的主页： http://liguifa.wang  
他的知乎： https://www.zhihu.com/people/guifa-li  
他的邮箱： http://github.liguifa@outlook.com 
<br />欢迎造访交流！
