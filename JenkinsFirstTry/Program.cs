using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsFirstTry
{
    public class Program
    {
        static void Main(string[] args) {

            double s = BasicOps.Sum(3, 6);

        }
    }

    public static class BasicOps
    {
        public static double Sum(double a, double b) {
            return a + b;
        }
    }
}
