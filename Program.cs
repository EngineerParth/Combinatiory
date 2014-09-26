using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Combinationary{class Program{static void Main(string[] args){double N,r,a=1;N=10;r=10;a=f(N, r)/g(r);a=Math.Truncate(a);Console.WriteLine(a);Console.ReadKey();}
static double f(double n, double r){double t=1,c=0,i=n;while(c++<r){t*=i--;}return t;}
static double g(double n){double t=1, i=n;while(i>1){t*=i--;}return t;}}}
