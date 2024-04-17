using System.Runtime.CompilerServices;
//https://qiita.com/Euglenach/items/c433afe78d72fc1a18fc
//C# 8.0～
//C#のIndex構造体とRange構造体は、
//配列やリストなどのシーケンスに対して特定の要素を選択するための便利な方法を提供します。
//Index構造体:
//Index構造体は、配列要素を特定するためのもの。
//インデックス値 -1 は末尾の要素を表し、-2 はその前の要素を表し、以降も同様です。
var a = new[] { 1, 2, 3, 4, 5 };
Index i = ^1;
Console.WriteLine(a[i]);
Console.WriteLine("");
//正の整数のインデックスは先頭からの位置を表します。具体的には、^0 は最後の要素、^1 は最後から2番目の要素、^2 は最後から3番目の要素を表します。

//Range構造体: Range構造体は、シーケンス内の連続した要素のサブセットを選択するためのものです。start..end の形式で使用され、start は含まれ、end は含まれないインデックスを示します。また、省略された場合、start は先頭、end は末尾として扱われます。例えば、0..3 は先頭から3番目までの要素を含みますが、3番目の要素は含まれません。

//これらの構造体を使用すると、より直感的で読みやすいコードを書くことができます。例えば、以下のように使用できます:


//前後1要素ずつ削ったもの
var trim = a[1..^1];
Write(trim);

//i..j は「iは含んでjは含まない」という範囲になります。
//for (var x = i; x < j; ++x) のイメージ
//3番目から4番目まで
int s = 3 - 1;
int e = 4;
var mid = a[s..e];
Write(mid);

static void Write(int[] v)
{
    foreach (var x in v)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine("");
}