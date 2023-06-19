﻿using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);
        }

        //メソッドの概要： 
        //科目ごとの点数を集計してIDitcionaryとしてリストのような形で返す
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new SortedDictionary<string, int>();
            foreach(var sale in _score) {
                if (dict.ContainsKey(sale.Subject)) {
                    dict[sale.Subject] += sale.Score;
                }
                else {
                    dict[sale.Subject] = sale.Score;
                }
            }

            return dict;


        }

        //メソッドの概要： 
        //filePathで受け取ったパスからStudentのリストを作り、そのリストを返す
        //１行ずつ読んでは、Studentの中身としてStudentのコンストラクタを呼び出す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines) {
                var items = line.Split(',');
                var score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(score);
            }
            return students;




        }

       
    }
}
