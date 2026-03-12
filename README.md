# Lessons Recap C#


### Graphics
![alt text](image.png)

![alt text](image-1.png)


### Generic types & Classes
```cs
public interface IExample
{

}

public class Example<T> where T : IExample
{
  T Data { get; set; }

  public Example(T data) 
  {
    Data = data;
  }
}

public class ExampleTwo<T> 
{
  T DataType { get; set; }

  public ExampleTwo(T dataType) 
  {
    DataType = dataType;
  }
}

// In Program.cs

var stringExample = new Example<string>();

var stringTwoExample = new ExampleTwo<string>();
```
