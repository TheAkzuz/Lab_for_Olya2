namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Rectangle //������ �����
        {
            private int a; // ��� ��������� ����, � ���� ������ �������� ��� ������
            private int b;

            public Rectangle(int a, int b) //��� �����������, �� ���� ��� �������, ������� ����� ��������� 
                //���-�� ��� �������� �������
            {
                
                this.a = a; //����� ���������� ����������� ��������� � ������� �����, ������� ����� this 
                //��� �������� ��������� ����� �����
                this.b = b;
            }

            public int perimetr() // ��� �������(�����), ������� ���������� ��������.
            {
                int P = this.a *2 + this.b *2;
                return P;
            }

            public int s_funn()
            {
                return this.a * this.b;
            }

            //��� ��������, ������� ��������� �������� � ���������� ������ ��� ������
            public int Re_Line_A
            {

                get { return a; }//��� �� �������� �������� ����
                set { a = value; } //� ��� �� ������ �������� ����
            }

            public int Re_Line_B
            {
                get { return b; }
                set { b = value; }
            
            }

            public string Cheak_kv
            {
                get //��� ���� ��������, ������� ��������� �����.
                {
                    if (a == b)
                    {
                        return "��� �������";
                    }
                    else
                    {
                        return "��� �� �������";
                    }
                }
            }


            //��� ����������, ������� ��������� �������� � ���������� ������ ��� ������ ����� �����
            public int this[int i]
            {
                get
                {
                    if (i == 0)
                    {
                        return a;
                    }

                    else if (i == 1)
                    {
                        return b;
                    }

                    else // ��� ������ ������ ���-�� ���������.
                    {
                        return -1;
                    }
                }
            }

            // ��� �� ������ ������������ ����������. ����� ������ �� ����� ��� �� ��������� � ������
            //�� ��������� ������ ������ ������. ������� �� ������� � �������
            // ����� �������� �� ������� ����� ������ �������� �� �������
            public static Rectangle operator ++(Rectangle A)
            {
                A.Re_Line_A++;
                A.Re_Line_B++;
                return A;
            }
            public static Rectangle operator --(Rectangle A)
            {
                A.Re_Line_A--;
                A.Re_Line_B--;
                return A;
            }

            // ��� �� ������� ���������� ���������, �� �� ������ ������ ��� �������������

            public static bool operator true(Rectangle A)
            {
                if (A.a == A.b)
                {
                    return true;
                }
                return false;
            }
            public static bool operator false(Rectangle A)
            {
                if (A.a != A.b)
                {
                    return false;
                }
                return true;
            }

            //��� �� ��������� ����� ������, �� � ������� �� ����� ����� ������� ���.���������
            public static Rectangle operator *(Rectangle A, int c)

            {
                A.a = A.a * c;
                A.b = A.b * c;
                return A;
            }

        }



        private void button1_Click(object sender, EventArgs e) // ��� ������� ��������� �� ������� ������.
        {
            listView1.Items.Clear(); // ��� �� ������ ����� ������ �� ������
            int a = Convert.ToInt32(textBox1.Text); //��� ������ ���������� �, ������� �������� �����,
            //������� �� ������ � ��������, �� �� ����� � ����� ������.�����32 �� ��������� ��� � �����
            int b = Convert.ToInt32(textBox2.Text);//� ��� �����
            Rectangle A = new Rectangle(a,b); //������ ������ ������ ��������� � �������� ��� �����������
            //��������� ������������ ��������� �������� � � � , ������� �� ������� ����

            listView1.Items.Add("P =" + A.perimetr()); // ��������� �� ����� ������ ��������� ������ ������ ������.
            listView1.Items.Add("S="+ A.s_funn());//� ��� �����
            label3.Text = A.Cheak_kv; //� ��� ������ ��������� �������� � ������� ��� � ����� ������.

            //�� ������ ����� ��������� ������ ������� ��� ����������
        }
    }
}