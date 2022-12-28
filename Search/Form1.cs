using System;
using System.Windows.Forms;

namespace Search
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //yyyy-mm-dd
        {
            //search.newsearch URL = "@C:\\Users\\dokki\\source\\repos\\깨끗한나라\\깨나라영상";
            //> File.newFile C: \Users\dokki\source\repos\깨끗한나라\깨나라영상 / t:"General\Text File"
            //> Edit.Find ^^t / regex
            //> Edit.FindinFiles 2022-12-16 / lookin:"C:\\Users\\dokki\\source\repos\\깨끗한나라\\깨나라영상" / ext:*.mkv / text3;

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //hh-mm-ss
        {
            //> File.newFile C: \Users\dokki\source\repos\깨끗한나라\깨나라영상 / t:"General\Text File"
            //> Edit.Find ^^t / regex
            //> Edit.FindinFiles 10-43-59 / lookin: "C:\\Users\\dokki\\source\repos\\깨끗한나라\\깨나라영상" / ext:*.mkv / text4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.OpenFile filename [/C:\Users\dokki\source\repos\깨끗한나라\깨나라영상]

        }

        private void form_Load(object sender, EventArgs e)
        {
            //    > File.newfile C: \Users\dokki\source\repos\깨끗한나라\깨나라영상 / t:"General\Text File"
            //    > Edit.Find ^^t / regex
            //    > Edit.FindinFiles 2022-12-16 / lookin:"C:\\Users\\dokki\\source\repos\\깨끗한나라\\깨나라영상" / ext:*.mkv / text3;
            //    File.openfile filename[/ C:editorname];
            //

        }
        
    }
}