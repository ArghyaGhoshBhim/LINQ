// See https://aka.ms/new-console-template for more information


int[] age = { 12, 23, 13, 33, 21, 22 };
var a =from i in age where i>20 orderby i descending select i;

foreach (var item in a)
{
    Console.WriteLine(item);
}
