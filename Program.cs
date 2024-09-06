var source = File.ReadAllText(@"D:\圆周率.txt").AsSpan();
Console.WriteLine("请输入生日,例如19871229");
var birthday = Console.ReadLine();
Console.WriteLine(source.IndexOf(birthday.AsSpan()));
