using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIO.DataBase
{
    public partial class Enrollee
    {
        public string FIO
        {
            get
            {
                string result = SecondNameEnrollee + " " + FirstNameEnrollee[0] + ". ";

                if (!string.IsNullOrWhiteSpace(MiddleNameEnrollee))
                    result += MiddleNameEnrollee[0] + ".";

                return result;
            }
        }
        public double AverageScore
        {
            get
            {
                if (EnrolleeDocument.CertificateScore == null)
                    return (double)EnrolleeDocument.DiplomScore;
                else
                    return (double)EnrolleeDocument.CertificateScore;
            }
        }
    }
}
