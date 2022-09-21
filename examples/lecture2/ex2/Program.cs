int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
Console.Clear();

int a1 = 34; int a2 = 3;   int a3 = 314;
int b1 = 33; int b2 = 4;   int b3 = 324;
int c1 = 31; int c2 = 334; int c3 = 3224;

/*m
int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3); 
 */
Console.WriteLine(Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3)));






