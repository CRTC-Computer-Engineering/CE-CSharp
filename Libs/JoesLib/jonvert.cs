using System;

namespace JoesLib
{
    public class jonvert
    {
        public static string convertGradeToLetter(double grade){
            if (grade > 97){return "A+";}
            else if (grade > 93){return "A";}
            else if (grade > 90){return "A-";}
            else if (grade > 87){return "B+";}
            else if (grade > 83){return "B";}
            else if (grade > 80){return "B-";}
            else if (grade > 77){return "C+";}
            else if (grade > 73){return "C";}
            else if (grade > 70){return "C-";}
            else if (grade > 67){return "D+";}
            else if (grade > 63){return "D";}
            else if (grade > 60){return "D-";}
            else {return "F";}
        }
    }
}
