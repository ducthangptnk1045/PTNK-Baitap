using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        static int a, b, z, wrong;
        static int g=0, dem=0, l = 0;
        static string mst = "", ansmoral = "";
        static string[] m1 = new string[10];
        static string[] m2 = new string[10];
        static string[] m3 = new string[10];
        
        static string kk = "";
        
        public static void init()
        {
            m1[1] = " mốt";           m2[2] = " hai";              m3[1] = " một";      
            m1[3] = " ba";            m2[4] = " bốn";              m3[2] = " hai";
            m1[5] = " lăm";           m2[6] = " sáu";              m3[3] = " ba";
            m1[7] = " bảy";           m2[8] = " tám";              m3[4] = " bốn"; 
            m1[9] = " chín";          m2[1] = " một";              m3[5] = " năm";
            m1[2] = " hai";           m2[3] = " ba";               m3[6] = " sáu";
            m1[4] = " bốn";           m2[5] = " năm";              m3[7] = " bảy";
            m1[6] = " sáu";           m2[7] = " bảy";              m3[8] = " tám";
            m1[8] = " tám";           m2[9] = " chín";             m3[9] = " chín";
            m1[0] = "";                  m2[0] = "";                     m3[0] = " không";
         
        }

        static void moral()
        {
            if ((b == -1) || (z == -1) || (a == -1))
            {
                if ((b == -1) && (z == -1))
                {
                    if (a == 0) ansmoral = "";
                    else ansmoral = m3[a] + kk;
                }
                if (b == -1) ansmoral = m3[a] + kk;
                //   else if ((b != -1)&&(z == -1)) ansmoral = "mười" + m2[b] + m1[a] + kk;
                else if ((z == -1) && (b == 1) && (a == 1)) ansmoral = "mười một " + kk;
                else if ((z == -1) && (b == 1) && (a != 1)) ansmoral = "mười " + m1[a] + kk;
                else if ((z == -1) && (b != 1) && (b != -1)) ansmoral = m2[b] +" mươi" + m1[a] + kk;
                //  else if ((z == -1) && (b == 1) && (a == 0)) ansmoral ="mười" + m2[b] + m1[a] + kk;
            }
            else if ((a == 0) && (b != 0) && (z != 0))
            {
                ansmoral = m3[z] + " trăm" + m2[b] + " mươi" + kk;
            }           
            else if ((a != 0) && (b == 0) && (z != 0))
            {
                ansmoral = m3[z] + " trăm" + " lẻ" + m3[a] + kk;
            }                    
            else if ((a == 0) && (b == 0) && (z != 0))
            {
                ansmoral = m3[z] + " trăm" + kk; ;
            }
            else if (Form1.st.Length != 0)
            {
                if (z == 0)
                {
                    if ((b == 0) && (a != 0)) ansmoral = m3[z] + " trăm" + " lẻ" + m3[a] + kk;
                    else if ((b == 1)) ansmoral = m3[z] + " trăm" + " mười" + m1[a] + kk;
                    else if ((a == 0) && (b == 0) && (z == 0)) ansmoral = "";
                    else ansmoral = m3[z] + " trăm" + m2[b] + " mươi" + m1[a] + kk;
                }                 
                else if ((b == 1) && (a == 1)) ansmoral = m3[z] + " trăm" + " mười một" + kk;
                else if (b == 1) ansmoral = m3[z] + " trăm" + " mười" + m1[a] + kk;
                else ansmoral = m3[z] + " trăm" + m2[b] + " mươi" + m1[a] + kk;
            }
            else 
            {
                ansmoral = m3[z] + " trăm" + m2[b] + " mươi" + m2[a] + kk;
            }

        }
         static void operation()
         {
            dem++;
            a = -1; b = -1; z = -1; wrong = 0;
            if (dem == 2) kk = " nghìn";          
            if (dem == 3) kk = " triệu";
            if (dem == 4) kk = " tỷ";
            a = Int16.Parse(mst.Substring(2));
            mst = mst.Remove(2, 1);
            try
            {
                b = Int16.Parse(mst.Substring(1));
            }
            catch
            {
                if (b<0)
                {
                    wrong = 1; 
                }
            }
            finally
            {
                if(wrong!=1) b = Int16.Parse(mst.Substring(1));
            }
            mst = mst.Remove(1, 1);
            if((wrong!=1)&&(b>=0)&&(mst!="#"))
            {
                z = Int16.Parse(mst);
            }
            moral();
            Form1.finals = ansmoral + Form1.finals;
            ansmoral = ""; 
         }
        public static void xuly()
        {
            dem = 0;
            kk = "";
            Form1.finals = "";
            l = Form1.st.Length % 3;
            if (l != 0)
            {
                for (int i = 1; i <= 3 - l; l++)
                {
                    Form1.st = "#" + Form1.st;
                }
            }
            init();
            while (Form1.st.Length >=3)
                {
                    g = Form1.st.Length; 
                    mst = Form1.st.Substring(Form1.st.Length - 3);
                        Form1.st = Form1.st.Remove(g-3,3);
                    operation();
                }
            
        }

    }
}

