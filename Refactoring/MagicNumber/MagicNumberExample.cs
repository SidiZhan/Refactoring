using System;
using System.Data;
using System.Net.Http;

namespace Refactoring.MagicNumber
{
    class MagicNumberExample
    {
        #region MagicNumber

        #endregion

        #region NotMagicNumber

        #endregion

        #region Example

        public dynamic GetAssigneeById(int assigneeId)
        {
            HttpClient httpClient = new HttpClient();
            return httpClient.GetAsync("http://localhost:10810/assignee/" + assigneeId);
        }

        public static float InverseSqrtFastAlgorithm(float x)
        {
            float xhalf = 0.5f * x;
            int i = 0x5f375a86 - (doSomething(x) >> 1);
            x = doSomething(i);
            x = x * (1.5f - xhalf * x * x);
            return x;
        }

        public string GetPersonNameById(int id)
        {
            DataTable dateTable = doSomething(id);
            return dateTable.Columns[0].ToString();
        }

        class Person
        {
            private readonly int Male = 0;
            private readonly int Female = 1;
            public int Gender { get; set; }
            Person(int gender)
            {
                Gender = gender;
            }
        }

        public void DoSomethingInArray()
        {
            int[] numbers = new int[10];
            for(int i = 0;i < 10; ++i)
            {
                doSomething(i);
            }
        }

        #endregion

        static dynamic doSomething(object i)
        {
            return i;
        }
    }
}