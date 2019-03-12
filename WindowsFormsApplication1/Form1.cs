using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Threading;
using System;
using System.IO;



namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label6.Text = "";
            label8.Text = "";

            //Initializing the LinkedList list and adding ToolBar the list box.
            LinkedList<string> list = new LinkedList<string>();
            for (int j = 0; j < 11; j++)
            {
                string jtext = j.ToString();
                list.AddFirst(jtext + " Value");
                LinkedList.Items.Add(list.First.Value);
            }

            list.AddLast("n Last Value ");
            LinkedList.Items.Add(list.Last.Value);
            //list.AddAfter(list.Find("1 First Value"), "2  Value");
            //list.AddAfter(0, "2 Value added");

            //Random randclass = new Random();
            //for (int a = 0; a < 5; a++)
            //{
            //    int randa = randclass.Next(0, 100);
            //    listBox3.Items.Add(randa);
            //    int randb = randclass.Next(0, 100);
            //    listBox4.Items.Add(randb);
            //}

            listBox3.Sorted = false;
            listBox4.Sorted = false;
            int[] arrayleft = { 100, 120, 15, 19, 2 };
            int[] arrayright = { 15, 9, 14, 8, 2 };

            for (int i = 0; i < 5; i++)
            {
                listBox3.Items.Add(arrayleft[i]);
                listBox4.Items.Add(arrayright[i]);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reverse a string
            if (editboxInputString.TextLength == 0)
            {
                MessageBox.Show("Please input some text into the Input String edit box.");
                return;
            }
            int i = 1; //Input string text counter
            string textbuffer = "";
            while (i <= editboxInputString.TextLength)
            {
                textbuffer = textbuffer + editboxInputString.Text.Substring(editboxInputString.TextLength - i, 1);
                i++;
            }

            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            //string reversedtext = editboxInputString.Text();
            ttsSynthall.SpeakAsync(textbuffer);
            editboxOutputString.Text = textbuffer;
            listBox1.Items.Add(textbuffer);
            Thread.Sleep(1000);

        }

        private void editboxInputString_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer ttsSynth = new SpeechSynthesizer();
            //string reversedtext = editboxInputString.Text();
            ttsSynth.SpeakAsync(editboxOutputString.Text);
            Thread.Sleep(500);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string selecteddate = monthCalendar1.SelectionStart.ToShortDateString();
            string daweek = monthCalendar1.SelectionStart.DayOfWeek.ToString();
            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            ttsSynthall.SpeakAsync(selecteddate);
            listBox1.Items.Add(selecteddate);
            listBox1.Sorted = true;

            //MessageBox.Show("You selected " + selecteddate);
            if (daweek == "Monday")
            {
                monthCalendar1.ShowWeekNumbers = true;
            }
            else
            {
                monthCalendar1.ShowWeekNumbers = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            ttsSynthall.SpeakAsync(listBox1.SelectedItem.ToString());
        }

        //say all the items in a list box
        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            //string itemtext;
            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            while (i < listBox1.Items.Count)
            { //itemtext = listBox1.Items[i].ToString();
                ttsSynthall.SpeakAsync(listBox1.Items[i].ToString());
                i++;
            }//foreach (listBox1 item in listBox1.Items) {    string name = item.Text;
        }

        //Clear a list box
        private void button3_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < listBox1.Items.Count; i++)
            int i = 0;
            while (i < listBox1.Items.Count)
            {
                listBox1.Items.Remove(listBox1.Items[i]);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", textBox1.Text))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    textBox1.Text.Remove(textBox1.Text.Length - 1);
            //} 

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {
            //Calls the factorial function
            string fac;
            Int32 facint;
            UInt64 fac64;
            fac = maskedTextBox1.Text;
            facint = Convert.ToInt32(fac);
            if (facint < 0)
            {
                MessageBox.Show("Factorial cannot handle negative numbers.");

            }
            else
            {
                fac64 = Convert.ToUInt64(fac);
                UInt64 result = factorial(fac64);
                textBox2.Text = result.ToString();
            }
        }

        //Recursive function factorial
        public static UInt64 factorial(UInt64 n)
        {
            if (n <= 1)
                return 1;
            else
                return n * factorial(n - 1);
        }

        public static string gettext()
        {
            //string getit = Console.ReadLine();
            String getit = MessageBox.Show("checking", "check", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question).ToString();//to check any specific response if(MessageBox.Show("checking", "check", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Yes)
            //string response = Microsoft.VisualBasic.Interaction.InputBox("Prompt", "Title", "DefaultResponse",5,5);
            return getit;
        }

        private void GetandSay_Click(object sender, EventArgs e)
        {
            string result = gettext();
            readtext(result);
        }

        public static void readtext(string foo)
        {
            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            ttsSynthall.SpeakAsync(foo);
            Thread.Sleep(1000);
        }
        //Reads in the English Dictionary
        public void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            int quotient = 0;
            Dictionary<string, int> diction = new Dictionary<string, int>();
            StreamReader MyStreamReader = new StreamReader(@"c:\Coding\englishwords.txt");

            while (MyStreamReader.EndOfStream == false)
            {
                diction.Add(MyStreamReader.ReadLine(), i);
                i++;
                //Reports status update every 10th read
                quotient = System.Math.DivRem(i, 10, out quotient);
                if (quotient == 0)
                {
                    label6.Text = i.ToString();
                    label6.Refresh();
                }
            }

            MyStreamReader.Close();

            //checks for palendromes
            int palendromecount = 0;
            int nonpalendromecount = 0;
            int bigwordcount = 0;
            int increment =0;
            //string strnew;
            string strtrim;
            foreach (string str in diction.Keys)
            {
                increment = 1;
                int front = 0;
                //strnew = str.Substring(0, str.Length - 1);
                //bool palendrome = false;
                strtrim = str.Trim();
                if (strtrim.Length >= 20)
                {
                    //listBox2.Items.Add(str);
                    //listBox2.Items.Insert(0, str);
                    bigwordcount++;
                    label8.Text = bigwordcount.ToString();
                    label8.Refresh();
                }
                while ((strtrim.Substring(front, 1) == strtrim.Substring(strtrim.Length - increment, 1)) && ((strtrim.Length) / 2 >= increment))
                {
                    increment++;
                    front++;
                }
                if (increment - 1 == (str.Length) / 2)
                {
                    //Comment, added semicolon to the Form1.cs file
                    listBox2.Items.Add(str);
                    palendromecount++;
                    listBox2.Refresh();

                }
                else
                {
                    nonpalendromecount++;
                }
                label5.Text = palendromecount.ToString();
                //label6.Text = nonpalendromecount.ToString();
                //label6.Text = increment.ToString(); //palendromecount.ToString() + nonpalendromecount.ToString();
                label6.Text = i.ToString();
                label6.Refresh();
                label5.Refresh();
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //sorts the array
            int[] arrayleft = { 100, 120, 15, 19, 2 };
            int[] arrayright = { 15, 9, 14, 8, 2 };
            Array.Sort(arrayleft);
            Array.Sort(arrayright);

            //updates the items in the list box with the sorted array values
            for (int i = 0; i < arrayleft.Count(); i++)
            {
                listBox3.Items[i] = (arrayleft[i]);
                listBox4.Items[i] = (arrayright[i]);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            //merge sort code
            int[] arrayleft = { 100, 12, 15, 19, 2 };
            int[] arrayright = { 2, 9, 16, 38, 77, 0, 0, 0, 0, 0 };
            Array.Sort(arrayleft);
            //Array.Sort(arrayright);
            int x = arrayright.Count() - 1;
            int left = arrayleft.Count() - 1;
            int right = 4;
            while (arrayleft.Count() > -1 && left > -1)
            {
                if (arrayleft[left] >= arrayright[right])
                {
                    arrayright[x] = arrayleft[left];
                    left--;
                    x--;
                }
                else
                {
                    arrayright[x] = arrayright[right];
                    right--;
                    x--;
                }
            }

            //clears the listbox of all items
            listBox5.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox5.Items.Add(arrayright[i]);
            }
            //int lft = 0;
            //int rght = 0;
            //int j = 1;
            //int lb3 = 0;
            //int lb4 = 0;
            //int i = 5;
            //for (int left = 0; i < 1; i--)
            //{
            //    lb3 = listBox3.Items.
            //    if (listBox3.Items[i] == listBox4.Items[i])
            //    {

            //    while (listBox3.Items.Count > 0)
            //    {
            //        lft = listBox3.Items.Count - 1;
            //        rght = listBox4.Items.Count - j;
            //        listBox4.Items.Insert(rght, listBox3.Items[lft]);
            //        listBox3.Items.RemoveAt(lft);
            //        j++;
            //        lb3 = listBox3.Items[0].ToString;
            //        if (listBox3.Items[0] <= listBox4.Items[0]) ;

            //    }
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Check for no input before running code
           if (richTextBox1.Text == "")
                MessageBox.Show("I like Software Testing!");
            //reverses the words in a sentence, loads them into an array with
            //the Fieldname.Text.Split then reverses the copies the array 
            //values back into a string and fills in the field.
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i = 1; //
            string outputtext = "";
            //string[] wordarray = Input.Text.Split(new char[] { ' ' });
            string[] testarray = richTextBox1.Text.Split(' ');
            i = testarray.Count() - 1;
            while (i > -1)
            {
                outputtext = outputtext + " " + testarray[i];
                i--;
            }
            richTextBox2.Text = outputtext.TrimStart();
            
            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            //string reversedtext = editboxInputString.Text();
            ttsSynthall.SpeakAsync(outputtext);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        //Calculate the distance between two points in 3d space.
        private void button10_Click_1(object sender, EventArgs e)
        {
            double[] decthreedpoints = new double[6];
            string[] threedpoints = points.Text.Split(',');
            for (int i = 0; i < 6; i++)
            {
                decthreedpoints[i] = Convert.ToDouble(threedpoints[i]);
            }
            double x = (decthreedpoints[1] - decthreedpoints[0]);
            double y = (decthreedpoints[3] - decthreedpoints[2]);
            double z = (decthreedpoints[5] - decthreedpoints[4]);
            double threeddistance = Math.Sqrt(x + y + z);
            distance.Text = threeddistance.ToString();

        }

        private void distance_TextChanged(object sender, EventArgs e)
        {

        }

        private void points_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteNode_Click(object sender, EventArgs e)
        {
            //listBox1.
            //list.AddAfter(list.Find("1 First Value"), "2  Value");
            //list.AddAfter(0, "2 Value added");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Int64 twotwentyfive = 0;
            int j;
            int k;
            string test;
            string ttf;
            bool foundit = false;
            for (twotwentyfive = 0; twotwentyfive < 1000000000000000125; twotwentyfive += 225)
            {
                ttf = twotwentyfive.ToString();
                label14.Text = ttf;
                label14.Refresh();
                for (int i = 0; i < ttf.Length; i++)
                {
                    test = ttf[0].ToString();
                    Int64 m = Convert.ToInt64(test);
                    if (m > 1)
                    {
                        Thread.Sleep(100);
                        switch (ttf.Length)
                        {
                            case 3:
                                twotwentyfive = 1125;
                                break;
                            case 4:
                                twotwentyfive = 10125;
                                break;
                            case 5:
                                twotwentyfive = 100125;
                                break;
                            case 6:
                                twotwentyfive = 1000125;
                                break;
                            case 7:
                                twotwentyfive = 10000125;
                                break;
                            case 8:
                                twotwentyfive = 100000125;
                                break;
                            case 9:
                                twotwentyfive = 1000000125;
                                break;
                            case 10:
                                twotwentyfive = 10000000125;
                                break;
                            case 11:
                                twotwentyfive = 100000000125;
                                break;
                            case 12:
                                twotwentyfive = 1000000000125;
                                break;
                            case 13:
                                twotwentyfive = 10000000000125;
                                break;
                            case 14:
                                twotwentyfive = 100000000000125;
                                break;
                            case 15:
                                twotwentyfive = 1000000000000125;
                                break;
                            case 16:
                                twotwentyfive = 10000000000000125;
                                break;
                            case 17:
                                twotwentyfive = 100000000000000125;
                                break;
                            case 18:
                                twotwentyfive = 1000000000000000125;
                                break;
                            default:
                                break;
                        }
                    }

                    j = ttf[i].CompareTo('0');
                    k = ttf[i].CompareTo('1');

                    if (j != 0 && k != 0)
                    {
                        break;
                    }
                    if (i == ttf.Length - 1)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Found value " + twotwentyfive.ToString() + ".  Look for more?", "Found a value...", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            foundit = true;
                        }
                    }
                }
                
                if (foundit == true)
                {
                    
                    break;
                }

            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void startThreadBack_Click(object sender, EventArgs e)
        {
            threadback.RunWorkerAsync();
        }

        private void threadback_DoWork(object sender, DoWorkEventArgs e)
        {
            Int64 twotwentyfive = 0;
            int j;
            int k;
            string ttf;
            bool foundit = false;
            for (twotwentyfive = 0; twotwentyfive < 9223372036854775807; twotwentyfive += 225)
            {
                ttf = twotwentyfive.ToString();
                this.label14.Text = ttf;
                this.label14.Refresh();
                for (int i = 0; i < ttf.Length; i++)
                {
                    j = ttf[i].CompareTo('0');
                    k = ttf[i].CompareTo('1');

                    if (j != 0 && k != 0)
                    {
                        break;
                    }
                    if (i == ttf.Length - 1)
                    {
                        DialogResult result;
                        result = MessageBox.Show("Found value " + twotwentyfive.ToString() + ".  Look for more?", "Found a value...", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            foundit = true;
                        }
                    }
                }

                if (foundit == true)
                {

                    break;
                }

            }

        }
       
        private void cancelThreadBack_Click(object sender, EventArgs e)
        {
            threadback.CancelAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddNode_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            editboxInputString.Text = "";
            editboxOutputString.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FreeSpacetext_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button14_Click(object sender, System.EventArgs e)
        {

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  File type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);
                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);
                    Freespace.Text = d.TotalFreeSpace.ToString();

                    // Console.WriteLine(
                    //   "  Total size of drive:            {0, 15} bytes ",
                    //   d.TotalSize);
                }

            }


        }

        private void btnReverseAString_Click(object sender, EventArgs e)
        {
            //reverse a string
            if ((editboxInputString.TextLength == -1) && (editboxInputString.TextLength < 0))
            {
                MessageBox.Show("Please input some text into the Input String edit box.");
                return;
            }

            int i = 1; //Input string text counter
            string textbuffer = "";
            while (i <= editboxInputString.TextLength)
            {
                textbuffer = textbuffer + editboxInputString.Text.Substring(editboxInputString.TextLength - i, 1);
                i++;
            }

            SpeechSynthesizer ttsSynthall = new SpeechSynthesizer();
            //string reversedtext = editboxInputString.Text();
            ttsSynthall.SpeakAsync(textbuffer);
            editboxOutputString.Text = textbuffer;
            listBox1.Items.Add(textbuffer);
            Thread.Sleep(1000);

        }

        private void btnReverseAString_MouseHover(object sender, EventArgs e)
        {
            //Mouse Hover

                //MessageBox.Show("Do you need help?");
                return;

        }

        private void editboxOutputString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

