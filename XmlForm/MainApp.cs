using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace sofxml
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Procedures.GetInfo();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name, n_zach, subject, mark, course, group;
                int temp;
                Add f = new Add();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    name = f.name;
                    n_zach = f.n_zach;
                    group = f.group;
                    mark = f.mark;
                    course = f.course;
                    subject = f.subject;
                    temp = Int32.Parse(mark);
                    if (name == "" || n_zach == "" || group == "" || course == "" || subject == "" || temp > 5||temp<1)
                    {
                        MessageBox.Show("Неверные данные");
                    }
                    else
                    {
                        Procedures.Add(name, group, course, n_zach, mark, subject);
                    }
                }
                label1.Text = Procedures.GetInfo();
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверные данные");
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mark, n_zach, subject;
            Remove f = new Remove();
            if (f.ShowDialog() == DialogResult.OK)
            {
                n_zach = f.n_zach;
                mark = f.mark;
                subject = f.subject;
                if (n_zach == "" ||mark =="" ||subject=="")
                {
                    MessageBox.Show("Запполните все поля");
                }
                else
                Procedures.Remove(n_zach, subject, mark);
            }
            label1.Text = Procedures.GetInfo();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string val;
            ToolStripMenuItem b = (ToolStripMenuItem)sender;
            subj s = new subj();
            if(s.ShowDialog()==DialogResult.OK)
            {
                val = s.val;
                if (val == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    switch (b.Text)
                    {
                        case "По предмету":
                            label1.Text = Procedures.SearchSubject(val);
                            break;
                        case "По оценке":
                            label1.Text = Procedures.SearchMark(val);
                            break;
                        case "По фамилии":
                            label1.Text = Procedures.SearchName(val);
                            break;
                        case "По номеру зач. книжки":
                            label1.Text = Procedures.SearchN_zach(val);
                            break;
                        case "По группе":
                            label1.Text = Procedures.SearchGroup(val);
                            break;
                        case "По курсу":
                            label1.Text = Procedures.SearchCourse(val);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void Average_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem b = (ToolStripMenuItem)sender;
            switch(b.Text)
            {
                case "По предмету":
                    label1.Text = Procedures.AVGSubj();
                    break;
                case "По курсу":
                    label1.Text = Procedures.AVGCourse();
                    break;
                case "По группе":
                    label1.Text = Procedures.AVGGroup();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Procedures
    {
        public static void Remove(string n_zach, string subject, string mark)
        {
            XDocument xdoc = XDocument.Load("students.xml");
            XElement root = xdoc.Element("students");
            foreach (XElement temp in root.Elements("student").ToList())
                if (temp.Element("n_zach").Value == n_zach && temp.Element("subject").Value == subject && temp.Element("mark").Value == mark)
                {
                    temp.Remove();
                }
            xdoc.Save("students.xml");
        }
        public static void Add(string name, string group, string course, string n_zach, string mark, string subject)
        {
            XDocument xdoc = XDocument.Load("students.xml");
            XElement root = xdoc.Element("students");
            root.Add(new XElement("student",
                             new XAttribute("name", name),
                             new XElement("subject", subject),
                             new XElement("mark", mark),
                             new XElement("n_zach", n_zach),
                             new XElement("Course", course),
                             new XElement("group", group)));
            xdoc.Save("students.xml");
        }
        public static string GetInfo()
        {
            string text="";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("n_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }

        public static string SearchName(string p_name)
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        where xe.Attribute("name").Value== p_name
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("n_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }

        public static string SearchN_zach(string p_zach)
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        where xe.Element("n_zach").Value == p_zach
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("n_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }
        public static string SearchGroup(string p_group)
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        where xe.Element("group").Value == p_group
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("n_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }
        public static string SearchMark(string p_mark)
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        where xe.Element("mark").Value == p_mark
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("n_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }
        public static string SearchCourse(string p_course)
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        where xe.Element("Course").Value == p_course
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("N_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }
        public static string SearchSubject(string p_subject)
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        where xe.Element("subject").Value == p_subject
                        select new Student
                        {
                            Name = xe.Attribute("name").Value,
                            Mark = xe.Element("mark").Value,
                            Group = xe.Element("group").Value,
                            N_zach = xe.Element("n_zach").Value,
                            Subject = xe.Element("subject").Value,
                            Course = xe.Element("Course").Value
                        };

            foreach (var item in items)
            {
                text = text + $"Студент: {item.Name}, Курс: {item.Course}, Группа: {item.Group}, Оценка: {item.Mark}, Предмет: {item.Subject}, Номер зачетной книжки: {item.N_zach}\n";
            }
            return text;
        }
        public static string AVGSubj()
        {
            string text="";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        select new
                        {
                            Mark = Int32.Parse(xe.Element("mark").Value),
                            Subject = xe.Element("subject").Value,
                        };
            var res = from temp in items
                      group temp by temp.Subject into g
                      select new
                      {
                          name = g.Key,
                          avg = g.Average(x => x.Mark)
                      };
            foreach (var item in res)
            {
                text = text + $"{item.name} : {item.avg} \n";
            }
            return text;
        }
        public static string AVGGroup()
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        select new
                        {
                            Mark = Int32.Parse(xe.Element("mark").Value),
                            Group = xe.Element("group").Value,
                        };
            var res = from temp in items
                      group temp by temp.Group into g
                      select new
                      {
                          name = g.Key,
                          avg = g.Average(x => x.Mark)
                      };
            foreach (var item in res)
            {
                text = text + $"{item.name} : {item.avg} \n";
            }
            return text;
        }
        public static string AVGCourse()
        {
            string text = "";
            XDocument xdoc = XDocument.Load("students.xml");
            var items = from xe in xdoc.Element("students").Elements("student")
                        select new
                        {
                            Mark = Int32.Parse(xe.Element("mark").Value),
                            Course = xe.Element("Course").Value,
                        };
            var res = from temp in items
                      group temp by temp.Course into g
                      select new
                      {
                          name = g.Key,
                          avg = g.Average(x => x.Mark)
                      };
            foreach (var item in res)
            {
                text = text + $"{item.name} : {item.avg} \n";
            }
            return text;
        }
       /* public static string Test(string Name,string Zachetka,string Mark,string Subject,string Course,string Group)
        {
            string text;
                text = $"Student: {Name} on course: {Course} from group: {Group} got {Mark} for {Subject} in his zachetka: {Zachetka}";
            return text;
        }

        public static bool TestDecimal(string str)
        {
            bool res = true;
            int test;
            try
            {
                test = Int32.Parse(str);
            }
            catch(FormatException)
            {
                res = false;
            }
            return res;
        }
        public static bool TestCondition(string name,string course,string zachetka,string group,string mark,string subject)
        {
            bool res = true;
            int temp = Int32.Parse(mark);
            if (name == "" || zachetka == "" || group == "" || course == "" || subject == "" || temp > 10 || temp < 1)
            {
                res = false;
            }
            return res;
        }*/
    }
    class Student
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public string Group { get; set; }
        public string N_zach { get; set; }
        public string Subject { get; set; }
        public string Course { get; set; }
    }
}
