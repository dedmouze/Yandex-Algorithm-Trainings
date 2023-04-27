using System;

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());
int E = int.Parse(Console.ReadLine());

if (A > B)
{
    A = A ^ B;
    B = B ^ A;
    A = A ^ B;
}
if(B > C)
{
    B = B ^ C;
    C = C ^ B;
    B = B ^ C;
}
if (A > B)
{
    A = A ^ B;
    B = B ^ A;
    A = A ^ B;
}
if (D > E)
{
    E = E ^ D;
    D = D ^ E;
    E = E ^ D;
}

if (A <= D && B <= E) Console.WriteLine("YES");
else Console.WriteLine("NO");