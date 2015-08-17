using DBEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploration
{    
    public class MyClass : IFun
    {

        void IFun.Fun1()
        {
            throw new NotImplementedException();
        }

        int IFun.Fun2()
        {
            throw new NotImplementedException();
        }
    }

    class MyFunClass
    {
        public void Fun()
        {
            MessageBox.Show("Fun()");
        }
        public void Fun(object x)
        {
            MessageBox.Show("Fun(object x)");
        }
        public void Fun(int x)
        {
            MessageBox.Show("Fun(int x)");
        }
        public void Fun(double x)
        {
            MessageBox.Show("Fun(double x)");
        }
        public void Fun(Int64 x = 15)
        {
            MessageBox.Show("Fun(double x)");
        }
    }

    public class Fun
    {
        
    }
    public class MyFun
    {
        //int x;
        //static int y;
        //void Funs()
        //{
        //    x = 1;
        //    y = 2;
        //}
        //static void Gun()
        //{
        //    x = 1;
        //    y = 2;
        //}
        static int next;
        int id;
        public MyFun()
        {
            id = next++;
        }
        public static int GetNextId()
        {
            return next;
        }
        public static void SetNextId(int val)
        {
            next = val;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //MyFun.SetNextId(76);
                //MyFun f1 = new MyFun();
                //MyFun f2 = new MyFun();
                //MessageBox.Show(MyFun.GetNextId().ToString());

                char c = 'A';
                int i = 90;
                ulong l = 22;

                double d = l;

                //ushort ush = 10;
                //sbyte sbyt = ush;
                //new MyFunClass().Fun("1.0");
                //new MyFunClass().Fun(111111111);

                //List<int> a = new List<int>();
                //a.Add(1);
                //a.Add(2);

                //List<int> b = new List<int>();
                //b.Add(1);
                //b.Add(2);
                //b.Add(3);
                //MessageBox.Show((a == b).ToString());


                //string Fun = "hello, World";
                //string s = Fun;
                //Type t = typeof(Fun);

                //MessageBox.Show(s);
                //MessageBox.Show(t.ToString());

                //int a = 10;
                //byte b = a;

                //var x;
                //var y = { 1, 2, 3 };
                //var z = null;
                //var u = x => x + 1;

            }
            catch (Exception Ex)
            {                
                throw;
            }
        }
    }
}
