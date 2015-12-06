using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace P13_3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private School school;

        public MainWindow()
        {
            InitializeComponent(); 
            Office o1 = new Office("计算机基础", "王军", "杨小勇", "何平", "姜涛");
            Office o2 = new Office("软件工程", "马建国", "陈君", "刘小燕");
            Office o3 = new Office("信息安全", "冯尧", "李建军", "张涛");
            Department d1 = new Department("计算机", o1, o2, o3);
            Office o4 = new Office("自动控制", "吴自力", "陈峰", "薛小龙");
            Office o5 = new Office("工业设计", "吴淑华", "方坤", "何力", "蔡聪");
            Department d2 = new Department("机电工程", o4, o5);
            Office o6 = new Office("信息管理", "赵民", "盛小楠", "徐小平");
            Office o7 = new Office("工商管理", "张敏", "李玲", "吕倩", "高剑");
            Department d3 = new Department("经济管理", o6, o7);
            school = new School("交通大学", d1, d2, d3);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TreeViewItem root = new TreeViewItem() { Header = school };
            treeView1.Items.Add(root);
            foreach (Department d in school.Departments)
            {
                TreeViewItem item = new TreeViewItem() { Header = d };
                root.Items.Add(item);
                foreach (Office o in d.Offices)
                    item.Items.Add(new TreeViewItem() { Header = o });
            }
        }

        private void treeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            listView1.Items.Clear();
            if (treeView1.SelectedItem == null)
                return;
            TreeViewItem item = (TreeViewItem)treeView1.SelectedItem;
            if (item.Header is School)
                foreach (Department d in school.Departments)
                    listView1.Items.Add(d);
            else if (item.Header is Department)
                foreach (Office o in ((Department)(item.Header)).Offices)
                    listView1.Items.Add(o);
            else if (item.Header is Office)
                foreach (string s in ((Office)item.Header).Teachers)
                    listView1.Items.Add(s);
        }
    }

    public class School
   {
      private string name;
      public string Name
      {
         get { return name; }
      }

      private List<Department> departments;
      public List<Department> Departments
      {
         get { return departments; }
      }

      public School(string name, params Department[] departments)
      {
         this.name = name;
         this.departments = new List<Department>(departments);
      }

      public override string ToString()
      {
         return name;
      }
   }

   public class Department
   {
      private string name;
      public string Name
      {
         get { return name; }
      }

      private List<Office> offices;
      public List<Office> Offices
      {
         get { return offices; }
      }

      public Department(string name, params Office[] offices)
      {
         this.name = name;
         this.offices = new List<Office>(offices);
      }

      public override string ToString()
      {
         return name + "系";
      }
   }

   public class Office
   {
      private string name;
      public string Name
      {
         get { return name; }
      }

      private List<String> teachers;
      public List<String> Teachers
      {
         get { return teachers; }
      }

      public Office(string name, params string[] teachers)
      {
         this.name = name;
         this.teachers = new List<string>(teachers);
      }

      public override string ToString()
      {
         return name + "教研室";
      }
   }
}
