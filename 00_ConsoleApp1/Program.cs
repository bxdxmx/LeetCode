var sw = new System.Diagnostics.Stopwatch();

var param = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //3628800通り

sw.Start();
//var list = _00_ClassLibrary.Class1.AllPermutation(param);         // 848ms
//var list2 = _00_ClassLibrary.Class1.Permutate(param).ToArray();     // 25,730ms
//var list3 = _00_ClassLibrary.Class1.AllPermutationYield(param).ToArray();         // 1095ms
var list4 = _00_ClassLibrary.Class1.Combination(param, 3).ToArray();         // 10ms

sw.Stop();

Console.WriteLine(sw.ElapsedMilliseconds);
