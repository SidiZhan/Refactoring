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

        public void GetAssigneeById(int assigneeId)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.GetAsync("http://localhost:10810/assignee/" + assigneeId);
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

        #endregion

        static dynamic doSomething(object i)
        {
            return i;
        }
    }
}