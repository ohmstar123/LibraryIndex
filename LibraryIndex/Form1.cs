﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryIndex
{
    public partial class Form1 : Form
    {
        List<Book> bookObjects = new List<Book>();
        List<string> bookTypes = File.ReadAllLines("BooksFile.txt").ToList();


        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < bookTypes.Count; i += 2)
            {
                int bookNumber = Convert.ToInt32(bookTypes[i]);
                string bookTitle = bookTypes[i + 1];

                Book bk = new Book(bookNumber, bookTitle);
                bookObjects.Add(bk);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Please enter the reference number");
            }
            int bookNumber = Convert.ToInt32(referenceNumberInput.Text);

            Boolean foundLinear = LinearSearch(bookObjects, bookNumber);
            linearSearchOutput.Text = foundLinear + "";

            Boolean foundBinary = BinarySearch(bookObjects, bookNumber);
            binarySearchOutput.Text = foundBinary + "";

            // bookObjects.Add(referenceNumberInput.Text);

        }

        public Boolean LinearSearch(List<Book> searchList, int searchValue)
        {
            foreach (Book s in searchList)
            {
                if (s == searchValue + "")
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean BinarySearch(List<Book> searchList, int searchValue)
        {
            int low = 0;
            int high = bookTypes.Count - 1;

            while(high >= low)
            {
                int middle = (low + high) / 2;
                int compare = searchList[middle].CompareTo(searchValue + ""); 

                if (compare == 0)
                {
                    return true;
                } 
                else if (compare < 0)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return false;

        }
    }
}
