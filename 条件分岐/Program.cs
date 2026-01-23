// See https://aka.ms/new-console-template for more information

//課題１

int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("偶数です");
}
else
{
    Console.WriteLine("奇数です");
}

//課題２
int Day = 
    int.Parse(Console.ReadLine());

switch (Day)
{
    case 1:
        Console.WriteLine("月曜日");
        break;

    case 2:
        Console.WriteLine("火曜日");
        break;

    case 3:
        Console.WriteLine("水曜日");
        break;

    case 4:
        Console.WriteLine("木曜日");
        break;

    case 5:
        Console.WriteLine("金曜日");
        break;

    case 6:
        Console.WriteLine("土曜日");
        break;

    case 7:
        Console.WriteLine("日曜日");
        break;

    default:
        Console.WriteLine("不正な入力です");
        break;

}

//課題３

int age = 20;
bool isStudent = true;

Console.WriteLine("年齢：" + age + " ," + "学生：" + isStudent);

if (age >= 18 && isStudent == true)
{
    Console.WriteLine("学生割引が適用されます");
}

//課題４
string ID = "admin";
string PW = "password123";

if (ID == "admin" || PW == "password123")
{
    Console.WriteLine("ログイン成功");
}
else
{
    Console.WriteLine("ログイン失敗");
}

//課題５
int score = 75;

Console.WriteLine("点数: " + score);


if (score >= 80 && score <= 100)
{
    Console.WriteLine("優秀");
}

else if (score >= 60 && score < 80)
{
    Console.WriteLine("合格");
}

else
{ 
        Console.WriteLine("不合格");
}
   
      
