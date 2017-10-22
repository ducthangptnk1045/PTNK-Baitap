using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class2
    { 
        static string[] m1 = new string[10];
        static string[] m2 = new string[20];
        static string[] m3 = new string[11];
        static string mst, tem, ansmoral, kk;
        static int a, b, c, r;
        public static void init()
        {
            m1[0] = "";                 m2[10] = " ten";            m3[0] = "";
            m1[1] = " one";             m2[11] = " eleven";         m3[1] = " ten";
            m1[2] = " two";             m2[12] = " twelve";         m3[2] = " twenty";
            m1[3] = " three";           m2[13] = " thirteen";       m3[3] = " thirty";
            m1[4] = " four";            m2[14] = " fourteen";       m3[4] = " fourty";
            m1[5] = " five";            m2[15] = " fifteen";        m3[5] = " fifty";
            m1[6] = " six";             m2[16] = " sixteen";        m3[6] = " sixty";
            m1[7] = " seven";           m2[17] = " seventeen";      m3[7] = " seventy";
            m1[8] = " eight";           m2[18] = " eighteen";       m3[8] = " eighty";
            m1[9] = " nine";            m2[19] = " nineteen";       m3[9] = " ninety";
        }

        static void moral()
        {
            ansmoral = "";
            if((b==-1)||(c == -1)) ansmoral = m1[a] +kk;
            if ((a != -1) && (b != -1) && (c != -1))
            {
                if (b == 1) ansmoral = m1[c] + " hundred" + m2[b * 10 + a] + kk ;
                if ((a == 0) && (b == 0) && (c == 0)) ansmoral = "";
                else ansmoral = m1[c] + " hundred" + m3[b] + m1[a] + kk;

            }
            if((b != -1)&&(c == -1))
            {
                if (b == 1) ansmoral = m2[b * 10 + a] + kk;
                else ansmoral = m3[b] + " " + m1[a] + kk ;
            }
        }
        static void main()
        {
            init();
            a = Int16.Parse(tem.Substring(tem.Length - 1));
            tem = tem.Remove(2, 1);
            if (tem.Substring(1) != "#")
            {
                b = Int16.Parse(tem.Substring(tem.Length - 1));
                tem = tem.Remove(1, 1);
                if (tem == "#") { c = -1; }
                else
                    c = Int16.Parse(tem);
            }
            else b = c = -1;
            r++;
            if (r == 2) kk = " thousand";
            if (r == 3) kk = " million";
            if (r == 4) kk = " billion";
            moral();
            Form1.finals = ansmoral + Form1.finals;
        }
        public static void operation()
        {
            r = 0;   kk = "";
            Form1.finals = "";
            mst = Form1.st;
            int g = Form1.st.Length; 
            if (g%3!=0)          
                for ( int i =1; i <=3-(g%3); i++ )
                {
                    mst = "#"+ mst;
                }         
            while(mst.Length>0)
            {
                tem = mst.Substring(mst.Length-3);
                mst = mst.Remove(mst.Length - 3, 3);
                main();
            }
        }
    }
}
