using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;

namespace HandicApp {
    public class Golfer {
        public Golfer(string name) {
            string[] data = File.ReadAllLines(name);
            string[] scores = new string[20];
            for(int i = 0; i < data.Length && i < 20; i++) {
                scores[i] = data[i].Split(',')[0];
            }
            double handicap = calculateHandicap(scores);
            Console.WriteLine();
            Console.WriteLine("Your Handicap: "+ handicap);
        }

        public static double calculateHandicap(string[] stringScores) {
            /* Calculates handicap assuming a slope of 120 and rating of 72 */
            double slope = 120;
            double rating = 72;
            double[] differentials = new double[20];
            int count = 0;
            for(int i = 0; i < 20 && stringScores[i] != null; i++) {
                differentials[i] = Convert.ToDouble(stringScores[i]);
                differentials[i] = ((differentials[i] - rating) * 113) / slope;
                count += 1;
            }
            Array.Resize(ref differentials, count);
            Array.Sort(differentials);
            if (differentials.Length < 10) return differentials[0] * .96;
            else if (differentials.Length < 20) {
                double diff = (differentials[0] + differentials[1] + differentials[2] + differentials[4] + differentials[3]) / 5;
                return diff * .96;
            }
            else {
                double sum = differentials[0] +differentials[1] + differentials[2] + differentials[3] + differentials[4]
                    + differentials[5] + differentials[6] + differentials[7] + differentials[8] + differentials[9];
                return (double) (sum/10) * .96;
            }
        }

        public static void updateScores(List<string[]> newScores, string name) {
            string[] data = File.ReadAllLines(name);
            List<string[]> scores = new List<string[]>();
            string[] newNewScores = new string[20];
            for(int i = 0; i < data.Length; i++) {
                scores.Add(data[i].Split(','));
            }
            List<string[]> concatenate = new List<string[]>();
            for(int i = 0; i < newScores.Count; i++) {
                concatenate.Add(newScores[i]);
            }
            for(int i = 0; i < scores.Count; i++) {
                concatenate.Add(scores[i]);
            }
            for(int i = 0; i < concatenate.Count && i < 20; i++) {
                newNewScores[i] = concatenate[i][0];
            }
            double newHandicap = calculateHandicap(newNewScores);
            Console.WriteLine();
            Console.WriteLine("Your updated handicap is: " + newHandicap);
            StreamWriter sw = new StreamWriter(name);
            for(int i = 0; i < concatenate.Count; i++) {
                sw.WriteLine(concatenate[i][0] + "," + concatenate[i][1] + "," + concatenate[i][2]);
            }
            sw.Close();
        }

        public static void searchDate(string date, string name) {
            Console.WriteLine();
            Console.WriteLine("Score(s) shot on " + date + ": ");
            string[] data = File.ReadAllLines(name);
            List<string[]> scores = new List<string[]>();
            for(int i = 0; i < data.Length; i++) {
                scores.Add(data[i].Split(','));
            }
            for(int i = 0; i < scores.Count; i++) {
                if(scores[i][1] == date) {
                    Console.WriteLine(scores[i][0] + " at " + scores[i][2]);
                }
            }
        }

        public static void searchCourse(string course, string name) {
            Console.WriteLine();
            Console.WriteLine("Score(s) shot at " + course + ": ");
            string[] data = File.ReadAllLines(name);
            List<string[]> scores = new List<string[]>();
            for(int i = 0; i < data.Length; i++) {
                scores.Add(data[i].Split(','));
            }
            for(int i = 0; i < scores.Count; i++) {
                if(scores[i][2] == course) {
                    Console.WriteLine(scores[i][0] + " on " + scores[i][1]);
                }
            }
        }
        public static string testFunction(string s) {
            return s;
        }
    }
}
