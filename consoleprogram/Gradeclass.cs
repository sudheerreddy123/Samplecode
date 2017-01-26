﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleprogram
{
    public class Gradeclass
    {
       
        public Gradeclass()
        {
            grade = new List<float>();
        }
                
        public Gradestatistics computestats()
        {
            Gradestatistics stats = new Gradestatistics();

            float sum = 0;
            foreach (float g in grade)
            {
                stats.Higheststats=Math.Max(g , stats.Higheststats);
                stats.Loweststats = Math.Min (g , stats.Loweststats);
                sum+= g;
            }
            stats .averagesats = sum /grade.Count;
            return stats ;
        }
         public void Addgrades(float a)
        {
            grade.Add(a);
        }
         public string Name;

         private List<float> grade;
        }
        
    }

