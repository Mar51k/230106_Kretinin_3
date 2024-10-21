using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _230106_Kretinin_4
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int evenCounter = 0, oddCounter = 0;
                int n = int.Parse(arrayN.Text);
                int start = int.Parse(array1.Text);
                int end = int.Parse(array2.Text);
                int[] arr = new int[n];
                Random rnd = new Random();

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(start, end + 1);
                }
                MessageBox.Show("Исходный массив: " + String.Join(", ", arr));


                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenCounter++;
                    }
                    else
                    {
                        oddCounter++;
                    }
                }

                SortEvenOdd(arr);
                MessageBox.Show("Отсортированный массив: " + String.Join(", ", arr));
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
        static void SortEvenOdd(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArray = new int[n];
            int evenIndex = 0;
            int oddIndex = n - 1;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0) 
                {
                    sortedArray[evenIndex++] = arr[i]; 
                }
                else
                {
                    sortedArray[oddIndex--] = arr[i]; 
                }
            }

            Array.Copy(sortedArray, arr, n);
        }

        private void arrayN_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((int.Parse(arrayN.Text) == 0))
                {
                    MessageBox.Show("Размерность массива не может быть меньше или равна 0!");
                    arrayN.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                arrayN.Text = null;
                
            }
            
        }

        private void array1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((int.Parse(array1.Text) == 0))
                {
                    MessageBox.Show("Размерность массива не может быть меньше или равна 0!");
                    array1.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                array1.Text = null;

            }
        }

        private void array2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((int.Parse(array2.Text) == 0))
                {
                    MessageBox.Show("Размерность массива не может быть меньше или равна 0!");
                    array2.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                array2.Text = null;

            }
        }
    }
}
