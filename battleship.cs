// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//battleship. 4 arrays (2 per user), 2 passwrd. ship sizes.
//user 1 enter password, user 2 enter password (time based?

// +-+-+-+-+-+-+-+-+-+-+-+-
// | | | | | | | | | | | | 
// +-+-+-+-+-+-+-+-+-+-+-+-
// | | | | | | | | | | | | 
// +-+-+-+-+-+-+-+-+-+-+-+-
// | | | | | | | | | | | | 
// +-+-+-+-+-+-+-+-+-+-+-+-
// | | | | | | | | | | | | 
// +-+-+-+-+-+-+-+-+-+-+-+-
// 
//   a b c d e f g h i j
// 1       ▲
// 2 ^△◄►◀▬▮◙○●▽△◁▷▯▭▶▼
// 3 V
// 4 <>
// 5
// 6
// 7
// 8
// 9
// 0

using System.Data;
using System.Runtime.CompilerServices;


short[,] p1target = new short[10,10];
short[,] p2grid = new short[10,10];
short[,] p2target = new short[10,10];
short[,] p1grid = new short[10,10];

