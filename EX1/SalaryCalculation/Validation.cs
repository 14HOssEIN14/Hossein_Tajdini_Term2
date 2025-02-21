using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public static class Validation
    {
        public static string ValidateNationalId(string id)
        {
           

            if (id.Length != 10) 
                throw new InvalidOperationException("NationalId Invalid");

            int controlnum = int.Parse(id.Substring(id.Length - 1));
            string idnum = id.Substring(0, 9);

            int sum = 0;
            for (int i = 0; i < idnum.Length; i++)
            {
                sum += (int.Parse(idnum[i].ToString()) * (10 - i));
            }

            int R = sum % 11;
            int calculatedControlNum = (R < 2) ? R : (11 - R);

            if (calculatedControlNum == controlnum)
                return id;
            else
                throw new InvalidOperationException("NationalId Invalid");
        }
        public static double ValidateBaseSalary(double baseSalary, double maxrange,double minrange)
        {
            if (baseSalary > maxrange || baseSalary < minrange)
            {
                throw new InvalidOperationException("Base Salary invalid");
            }
            else
                return baseSalary;

        }
        public static int ValidateExtraTimePerHours(int extraTimePerHours, int maxrange,int minrange)
        {
            if (extraTimePerHours > maxrange || extraTimePerHours < minrange)
            {
                throw new InvalidOperationException("Base Salary invalid");
            }
            else
                return extraTimePerHours;

        }
        public static string ValidateString(string txt,int maxlen,int minlen)
        {
            if (txt.Length < minlen||txt.Length>maxlen)
            {
                throw new InvalidOperationException("String Length Invalid");
            }else
                return txt;
        } 
       
    }
}
