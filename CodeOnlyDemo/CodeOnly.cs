using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace CodeOnlyDemo
{
    public class CodeOnly : Window
    {
        public CodeOnly()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Width = 500;
            Height = 300;
            Title = "Code Only";

            Grid grid = new Grid();

            Button btnTest = new Button();
            btnTest.Content = "测试";
            btnTest.Width = 100;
            btnTest.Height = 20;
            btnTest.VerticalAlignment = VerticalAlignment.Top;
            btnTest.HorizontalAlignment = HorizontalAlignment.Left;
            btnTest.Margin = new Thickness(30);

            btnTest.Click += BtnTest_Click;

            IAddChild container = grid;
            container.AddChild(btnTest);

            container = this;
            container.AddChild(grid);
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "你点击了按钮";
        }
    }
}
