
//不可变数据结构 （引用类型）
public record Person(string FirstName, string LastName);

public readonly record struct Point(double X, double Y, double Z);
