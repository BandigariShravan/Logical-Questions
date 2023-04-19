// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int[] a = { 0, 1, 1 };
int[] b = { 1, -10, 10 };
//int[] diffrence = new int[a.Length];

//for (int i = 0; i < a.Length; i++)
//{
//    int v1=0, v2=0;
//    if (a[i]<0)
//    {
//        v1 = (-a[i]);
//    }
//    else
//    {
//        v1 =a[i];
//    }
//    if (b[i]<0)
//    {
//        v2 = v1-b[i];
//    }
//    else
//    {
//        v2 = v1+b[i];
//    }
//    diffrence[i] = v2;
//}
int maxDiff = int.MinValue;

//int i = 0;
int index = 0;


for (int i = 0; i < a.Length ; i++)
{
    int gapValue = Math.Abs(a[i] - b[i]);
    //int var = gapValue.Max();

    if (gapValue > maxDiff)
    {
        maxDiff = gapValue;
       
        index = i;
    }
}

Console.WriteLine(index);
//int a =IndexOf( diffrence.Max());

//int index = Array.IndexOf(diffrence, var);

//Console.WriteLine(index);


//for (int i = 0; i < a.Length; i++)
//{
//    diffrence[i]=a[i]-b[i];
//}
//Console.WriteLine(diffrence.Max());