# 04_C#常用日志打印

    C#在调试过程中，我们通常使用Console.WriteLine("Something happened!");进行信息打印。在winform中为了将信息输出到界面，我们通常使用textBox和listBox进行界面信息打印，为了更便捷的输出到界面，可以封装好成函数，方便调用。

    在这里默认将textBox控件名称修改为：txtLog，调用函数为ShowMsg，在打印日志的时候默认方式为：ShowMsg("日志信息")。

    以下是一些常用的textBox输出形式：

日志打印，没有时间
```c#
private void ShowMsg(string str)
{
  	txtLog.AppendText(str + "\r\n"); // 每打印一行都会更新一行。
}
```

日志打印，添加了时间，可以记录具体时间发生的时间
```c#
private void ShowMsg(string str)
{
  	//时间格式可以根据具体情况调节
  	txtLog.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\r\n");

```

日志打印，每隔一定的行数会进行清理，经过测试过多的数据都输出在textBox上会导致卡顿
```c#
private void ShowMsg(string str)
{
    if (txtLog.Lines.Length > 10000)
    {
        txtLog.Clear();
    }
    txtLog.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\r\n");
}
```
// 日志打印，有时间，仅打印在界面上并不能保存，软件关闭后，无法进行后期回溯，这里单独添加了txt保存的功能，按天生成txt日志
```c#
private void ShowMsg(string str)
{
    txtLog.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\r\n");
    // 后面添加了txt记录的功能
    string fileName = DateTime.Now.ToString("yyyy_MM_dd_") + "log.txt";
    using (StreamWriter writer = File.AppendText(fileName))
    {
        writer.WriteLine($"{DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]")} - {str}");
    }
}
```
以上的功能基本上满足大部分需求，但存在一些情况，当多线程在记录到txt，有可能同时使用txt，会造成txt文件被占用，所以通过互斥锁来解决这个问题。如下：
```c#
// 添加互斥锁(解决文件被占用的处理方式)
private static readonly Mutex LogMutex = new Mutex(); // 在类的成员变量中声明互斥锁

private void ShowMsg(string str)
{
    try
    {
        txtLog.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str + "\r\n");
        LogMutex.WaitOne(); // 获取互斥锁
        string fileName = DateTime.Now.ToString("yyyy_MM_dd_") + "log.txt";
        using (StreamWriter writer = File.AppendText(fileName))
        {
            writer.WriteLine($"{DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]")} - {str}");
        }
    }
    finally
    {
        LogMutex.ReleaseMutex(); // 释放互斥锁
    }
}
```
以上是使用textBox的实现方式，下面这个是使用listBox实现的，功能是一样的，性能都能满足日志的输出，可以按照项目需要的方式进行修改，如加时间，记录到txt等，如下：

```c#
void ShowMsglist(string str)
{
    listBox1.Items.Add(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + str);
    listBox1.SelectedIndex = listBox1.Items.Count - 1;// 为了定位到最新的一行
    listBox1.ClearSelected();// 清除 listbox1 中所有选中的项
}
```