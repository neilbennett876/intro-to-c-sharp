// See https://aka.ms/new-console-template for more information
string stranger = "Another ";
int one = 1;

Console.WriteLine($"Hello, {stranger}{one}");

Console.Write(stranger.IndexOf("a").ToString());

int a = 10, b = 20, c = 40;

int sum = a + b + c;

double d = 22.0, e = 7.0;

double div = d / e;

var max = int.MaxValue;
int maxish = max + 3;

Console.WriteLine($"The sum is {sum} ");
Console.WriteLine($"What is 70/3? {div} ");
Console.WriteLine($"The maxish value is {maxish}");

Console.WriteLine("-------------- LIST-----------");

// int[] arr2 = new int[] {1,2,3,4,5};
var firstArr = new int[5] {-69, 23, 78, 21, 13};
// firstArr[0] = 100;

for (var i = 0; i < firstArr.Length; i++){
    Console.WriteLine($"The value at {i} is {firstArr[i]}");
}
foreach (var el in firstArr){
    Console.WriteLine($"The value is {el}");
}

List<int> list = new List<int>();

list.AddRange(firstArr);
list.Add(1000);
list.Add(1001);
list.Add(1002);
list.Add(1003);

foreach( var el in list) {
    Console.WriteLine($"The value is {el}");
}

Console.WriteLine($"The first element is {list[2]}");