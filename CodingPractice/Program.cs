using System;
using System.Diagnostics.Metrics;

// 1
/*
Dog myDog = new Dog();
myDog.Name = "초코";
myDog.Age = 3;
myDog.Bark();

Console.WriteLine($"이름: {myDog.Name}, 나이: {myDog.Age}살");

public class Dog
{
    public string Name;
    public int Age;

    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
    }
}

// 2

Monster monster1 = new Monster();
Console.WriteLine(monster1);

var monster2 = new Monster();
Console.WriteLine(monster2);

public class Monster
{
    public string Name;
}

// 3

Calculator calc = new Calculator();
calc.Add(3, 5);
calc.Multiply(4, 6);

public class Calculator
{
    public void Add(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"합계: {sum}");
    }

    public void Multiply(int x, int y)
    {
        int product = x * y;
        Console.WriteLine($"곱: {product}");
    }
}

// 4

Counter counter = new Counter();
counter.Increment();
counter.Increment();
counter.Increment();
counter.Reset();

public class Counter
{
    public int Count = 0;
    public void Increment()
    {
        Count++;
        Console.WriteLine($"현재 카운트: {Count}");
    }

    public void Reset()
    {
        Count = 0;
        Console.WriteLine("카운트가 초기화되었습니다.");
    }
}

// 5

GameManager.TotalPlayers = 10;
GameManager.ShowStatus();

GameManager manager = new GameManager();
manager.PlayerName = "홍길동";
manager.Greet();

public class GameManager
{
    public static int TotalPlayers = 0;

    public static void ShowStatus()
    {
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }

    public string PlayerName;

    public void Greet()
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }
}

// 6

Greeting.SayHello();
Farewell.Wave();

Greeting greeting = new Greeting();
greeting.SayGoodbye();

Farewell farewell = new Farewell();
farewell.Bow();

public class Greeting
{
    public static void SayHello()
    {
        Console.WriteLine("안녕하세요!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

public class Farewell
{
    public static void Wave()
    {
        Console.WriteLine("(손을 흔든다)");
    }

    public void Bow()
    {
        Console.WriteLine("(인사한다)");
    }
}


// 7

Item item = new Item();
item.Name = "포션";
item.Price = 100;

Console.WriteLine(item);

public class Item
{
    public string Name;
    public int Price;
}

// 8

Item item = new Item();
item.Name = "포션";
item.Price = 100;

Console.WriteLine(item);

public class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[아이템] {Name} - {Price}골드";
    }
}
*/
// 9

Player player1 = new Player();
player1.Name = "전사";
player1.Level = 10;
player1.Health = 200;

Player player2 = new Player();
player2.Name = "마법사";
player2.Level = 8;
player2.Health = 120;

Console.WriteLine(player1);
Console.WriteLine(player2);

public class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"[{Level}레벨] {Name} (HP: {Health})";
    }
}
